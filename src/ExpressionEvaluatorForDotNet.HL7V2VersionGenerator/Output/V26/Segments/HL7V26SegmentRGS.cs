using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentRGS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RGS"; } }

        public string SegmentId { get { return @"RGS"; } }
        
        public string LongName { get { return @"Resource Group"; } }
        
        public string Description { get { return @"The RGS segment is used to identify relationships between resources identified for a scheduled event. This segment can be used, on a site specified basis, to identify groups of resources that are used together within a scheduled event, or to describe some other relationship between resources. To specify related groups of resources within a message, begin each group with an RGS segment, and then follow that RGS with one or more of the Appointment Information segments (AIG, AIL, AIS, or AIP)."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",
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
                            Id = @"RGS.1",
                            Type = @"Field",
                            Position = @"RGS.1",
                            Name = @"Set ID - RGS",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a number that uniquely identifies the information represented by this segment in this transaction for the purposes of addition, change or deletion.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.2",
                            Type = @"Field",
                            Position = @"RGS.2",
                            Name = @"Segment Action Code",
                            Length = 3,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0206",
                            TableName = @"Segment action code",
                            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions. Refer to HL7 Table 0206 - Segment action code in Chapter 2, section 2.10.4.2, ""Action code/unique identifier mode update definition,"" for valid values.

This field is conditionally required.  It is required for all updating or modifying trigger events.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3",
                            Type = @"Field",
                            Position = @"RGS.3",
                            Name = @"Resource Group ID",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an identifier code describing the group of resources following this RGS segment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.1",
                            Type = @"Component",
                            Position = @"RGS.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.2",
                            Type = @"Component",
                            Position = @"RGS.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.3",
                            Type = @"Component",
                            Position = @"RGS.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.4",
                            Type = @"Component",
                            Position = @"RGS.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.5",
                            Type = @"Component",
                            Position = @"RGS.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.6",
                            Type = @"Component",
                            Position = @"RGS.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.7",
                            Type = @"Component",
                            Position = @"RGS.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.8",
                            Type = @"Component",
                            Position = @"RGS.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.9",
                            Type = @"Component",
                            Position = @"RGS.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V26SegmentRGS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field setIDRGS;

public HL7V26Field SetIDRGS
{
    get
    {
        if (setIDRGS != null)
        {
            return setIDRGS;
        }

        setIDRGS = new HL7V26Field
        {
            field = message[@"RGS"][1],
            Id = @"RGS.1",
            Type = @"Field",
            Position = @"RGS.1",
            Name = @"Set ID - RGS",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number that uniquely identifies the information represented by this segment in this transaction for the purposes of addition, change or deletion.",
            Sample = @"",
        };

        

        

        

        return setIDRGS;
    } 
}
internal HL7V26Field segmentActionCode;

public HL7V26Field SegmentActionCode
{
    get
    {
        if (segmentActionCode != null)
        {
            return segmentActionCode;
        }

        segmentActionCode = new HL7V26Field
        {
            field = message[@"RGS"][2],
            Id = @"RGS.2",
            Type = @"Field",
            Position = @"RGS.2",
            Name = @"Segment Action Code",
            Length = 3,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0206",
            TableName = @"Segment action code",
            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions. Refer to HL7 Table 0206 - Segment action code in Chapter 2, section 2.10.4.2, ""Action code/unique identifier mode update definition,"" for valid values.

This field is conditionally required.  It is required for all updating or modifying trigger events.",
            Sample = @"",
        };

        

        

        

        return segmentActionCode;
    } 
}
internal HL7V26Field resourceGroupID;

public HL7V26Field ResourceGroupID
{
    get
    {
        if (resourceGroupID != null)
        {
            return resourceGroupID;
        }

        resourceGroupID = new HL7V26Field
        {
            field = message[@"RGS"][3],
            Id = @"RGS.3",
            Type = @"Field",
            Position = @"RGS.3",
            Name = @"Resource Group ID",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier code describing the group of resources following this RGS segment.",
            Sample = @"",
        };

        

        

        

        return resourceGroupID;
    } 
}

    }
}
