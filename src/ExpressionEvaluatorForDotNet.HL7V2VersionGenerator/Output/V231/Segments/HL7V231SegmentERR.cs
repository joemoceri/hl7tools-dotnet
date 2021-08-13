using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentERR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ERR"; } }

        public string SegmentId { get { return @"ERR"; } }
        
        public string LongName { get { return @"Error segment"; } }
        
        public string Description { get { return @"The ERR segment is used to add error comments to acknowledgment messages.
It contains one field only storing the code and the location."; } }
        
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

        public HL7V231SegmentERR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _errorCodeandLocation;

public HL7V231Field ErrorCodeandLocation
{
    get
    {
        if (_errorCodeandLocation != null)
        {
            return _errorCodeandLocation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ERR.1",
            Type = @"Field",
            Position = @"ERR.1",
            Name = @"Error Code and Location",
            Length = 80,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ELD",
            DataTypeName = @"Error",
            TableId = null,
            TableName = null,
            Description = @"This field identifies an erroneous segment in another message. The second component is an index if there is more than one segment of type <segment ID>. For systems that do not use the HL7 Encoding Rules, the data item number may be used for the third component. The fourth component (which references HL7 Table 0357 - Message error condition codes, (as a CE data type)) is restricted from having any subcomponents as the subcomponent separator is now the CE's component separator.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERR.1.1",
                            Type = @"Component",
                            Position = @"ERR.1.1",
                            Name = @"Segment ID",
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
                            Id = @"ERR.1.2",
                            Type = @"Component",
                            Position = @"ERR.1.2",
                            Name = @"Sequence",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.3",
                            Type = @"Component",
                            Position = @"ERR.1.3",
                            Name = @"Field Position",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ERR.1.4",
                            Type = @"Component",
                            Position = @"ERR.1.4",
                            Name = @"Code Identifying Error",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0357",
                            TableName = @"Message error condition codes",
                            Description = @"The fourth component (which references HL7 Table 0357 - Message error condition codes,  (as a CE data type)) is restricted from having any subcomponents as the subcomponent separator is now the CE’s component separator",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ERR.1.4.1",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.1",
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
                            Id = @"ERR.1.4.2",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.2",
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
                            Id = @"ERR.1.4.3",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.3",
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
                            Id = @"ERR.1.4.4",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.4",
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
                            Id = @"ERR.1.4.5",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.5",
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
                            Id = @"ERR.1.4.6",
                            Type = @"SubComponent",
                            Position = @"ERR.1.4.6",
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
                        },}
                        },
                        }
        }

        _errorCodeandLocation = new HL7V231Field
        {
            field = message[@"ERR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorCodeandLocation.field.FieldRepetitions != null && _errorCodeandLocation.field.FieldRepetitions.Count > 0)
        {
            _errorCodeandLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_errorCodeandLocation, fieldData);
        }

        return _errorCodeandLocation;
    } 
}
    }
}
