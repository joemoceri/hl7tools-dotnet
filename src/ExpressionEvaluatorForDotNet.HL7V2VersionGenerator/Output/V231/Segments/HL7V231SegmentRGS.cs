using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentRGS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RGS"; } }

        public string SegmentId { get { return @"RGS"; } }
        
        public string LongName { get { return @"Resource group segment"; } }
        
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

        public HL7V231SegmentRGS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _setIDRGS;

public HL7V231Field SetIDRGS
{
    get
    {
        if (_setIDRGS != null)
        {
            return _setIDRGS;
        }

        var fieldData = new HL7V231FieldData
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
            Fields = null
        }

        _setIDRGS = new HL7V231Field
        {
            field = message[@"RGS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDRGS.field.FieldRepetitions != null && _setIDRGS.field.FieldRepetitions.Count > 0)
        {
            _setIDRGS.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_setIDRGS, fieldData);
        }

        return _setIDRGS;
    } 
}

internal HL7V231Field _segmentActionCode;

public HL7V231Field SegmentActionCode
{
    get
    {
        if (_segmentActionCode != null)
        {
            return _segmentActionCode;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions. Refer to HL7 table 0206 - Segment action code in Chapter 2, Section 2.23.4.2, 'Action code/unique identifier mode update definition,' for valid values.",
            Sample = @"",
            Fields = null
        }

        _segmentActionCode = new HL7V231Field
        {
            field = message[@"RGS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_segmentActionCode.field.FieldRepetitions != null && _segmentActionCode.field.FieldRepetitions.Count > 0)
        {
            _segmentActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_segmentActionCode, fieldData);
        }

        return _segmentActionCode;
    } 
}

internal HL7V231Field _resourceGroupID;

public HL7V231Field ResourceGroupID
{
    get
    {
        if (_resourceGroupID != null)
        {
            return _resourceGroupID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"RGS.3",
            Type = @"Field",
            Position = @"RGS.3",
            Name = @"Resource Group ID",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier code describing the group of resources following this RGS segment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RGS.3.1",
                            Type = @"Component",
                            Position = @"RGS.3.1",
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
                            Id = @"RGS.3.2",
                            Type = @"Component",
                            Position = @"RGS.3.2",
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
                            Id = @"RGS.3.3",
                            Type = @"Component",
                            Position = @"RGS.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.4",
                            Type = @"Component",
                            Position = @"RGS.3.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RGS.3.5",
                            Type = @"Component",
                            Position = @"RGS.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
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
                            Id = @"RGS.3.6",
                            Type = @"Component",
                            Position = @"RGS.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _resourceGroupID = new HL7V231Field
        {
            field = message[@"RGS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resourceGroupID.field.FieldRepetitions != null && _resourceGroupID.field.FieldRepetitions.Count > 0)
        {
            _resourceGroupID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_resourceGroupID, fieldData);
        }

        return _resourceGroupID;
    } 
}
    }
}
