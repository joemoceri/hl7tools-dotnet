using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentRF1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RF1"; } }

        public string SegmentId { get { return @"RF1"; } }
        
        public string LongName { get { return @"Referral Infomation"; } }
        
        public string Description { get { return @"This segment represents information that may be useful when sending referrals from the referring provider to the referred-to provider."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

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
                            Id = @"RF1.1",
                            Type = @"Field",
                            Position = @"RF1.1",
                            Name = @"Referral Status",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0283",
                            TableName = @"Referral status",
                            Description = @"This field contains the status of the referral as defined by either the referred-to or the referred-by provider. Refer to user-defined table 0283 - Referral status for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.1.1",
                            Type = @"Component",
                            Position = @"RF1.1.1",
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
                            Id = @"RF1.1.2",
                            Type = @"Component",
                            Position = @"RF1.1.2",
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
                            Id = @"RF1.1.3",
                            Type = @"Component",
                            Position = @"RF1.1.3",
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
                            Id = @"RF1.1.4",
                            Type = @"Component",
                            Position = @"RF1.1.4",
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
                            Id = @"RF1.1.5",
                            Type = @"Component",
                            Position = @"RF1.1.5",
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
                            Id = @"RF1.1.6",
                            Type = @"Component",
                            Position = @"RF1.1.6",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.2",
                            Type = @"Field",
                            Position = @"RF1.2",
                            Name = @"Referral Priority",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0280",
                            TableName = @"Referral priority",
                            Description = @"This field contains the urgency of the referral. Refer to user-defined table 0280 - Referral priority for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.2.1",
                            Type = @"Component",
                            Position = @"RF1.2.1",
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
                            Id = @"RF1.2.2",
                            Type = @"Component",
                            Position = @"RF1.2.2",
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
                            Id = @"RF1.2.3",
                            Type = @"Component",
                            Position = @"RF1.2.3",
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
                            Id = @"RF1.2.4",
                            Type = @"Component",
                            Position = @"RF1.2.4",
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
                            Id = @"RF1.2.5",
                            Type = @"Component",
                            Position = @"RF1.2.5",
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
                            Id = @"RF1.2.6",
                            Type = @"Component",
                            Position = @"RF1.2.6",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.3",
                            Type = @"Field",
                            Position = @"RF1.3",
                            Name = @"Referral Type",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0281",
                            TableName = @"Referral type",
                            Description = @"This field contains the type of referral. It is loosely associated with a clinical specialty or type of resource. Refer to user-defined table 0281 - Referraltype for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.3.1",
                            Type = @"Component",
                            Position = @"RF1.3.1",
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
                            Id = @"RF1.3.2",
                            Type = @"Component",
                            Position = @"RF1.3.2",
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
                            Id = @"RF1.3.3",
                            Type = @"Component",
                            Position = @"RF1.3.3",
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
                            Id = @"RF1.3.4",
                            Type = @"Component",
                            Position = @"RF1.3.4",
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
                            Id = @"RF1.3.5",
                            Type = @"Component",
                            Position = @"RF1.3.5",
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
                            Id = @"RF1.3.6",
                            Type = @"Component",
                            Position = @"RF1.3.6",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.4",
                            Type = @"Field",
                            Position = @"RF1.4",
                            Name = @"Referral Disposition",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0282",
                            TableName = @"Referral disposition",
                            Description = @"This field contains the type of response or action that the referring provider would like from the referred-to provider. Refer to user-defined table 0282 - Referral disposition for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.4.1",
                            Type = @"Component",
                            Position = @"RF1.4.1",
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
                            Id = @"RF1.4.2",
                            Type = @"Component",
                            Position = @"RF1.4.2",
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
                            Id = @"RF1.4.3",
                            Type = @"Component",
                            Position = @"RF1.4.3",
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
                            Id = @"RF1.4.4",
                            Type = @"Component",
                            Position = @"RF1.4.4",
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
                            Id = @"RF1.4.5",
                            Type = @"Component",
                            Position = @"RF1.4.5",
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
                            Id = @"RF1.4.6",
                            Type = @"Component",
                            Position = @"RF1.4.6",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.5",
                            Type = @"Field",
                            Position = @"RF1.5",
                            Name = @"Referral Category",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0284",
                            TableName = @"Referral category",
                            Description = @"This field contains the location at which the referral will take place. Refer to user-defined table 0284 - Referral category for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.5.1",
                            Type = @"Component",
                            Position = @"RF1.5.1",
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
                            Id = @"RF1.5.2",
                            Type = @"Component",
                            Position = @"RF1.5.2",
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
                            Id = @"RF1.5.3",
                            Type = @"Component",
                            Position = @"RF1.5.3",
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
                            Id = @"RF1.5.4",
                            Type = @"Component",
                            Position = @"RF1.5.4",
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
                            Id = @"RF1.5.5",
                            Type = @"Component",
                            Position = @"RF1.5.5",
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
                            Id = @"RF1.5.6",
                            Type = @"Component",
                            Position = @"RF1.5.6",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.6",
                            Type = @"Field",
                            Position = @"RF1.6",
                            Name = @"Originating Referral Identifier",
                            Length = 30,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the originating application's permanent identifier for the referral. This is a composite field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.6.1",
                            Type = @"Component",
                            Position = @"RF1.6.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.6.2",
                            Type = @"Component",
                            Position = @"RF1.6.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.6.3",
                            Type = @"Component",
                            Position = @"RF1.6.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.6.4",
                            Type = @"Component",
                            Position = @"RF1.6.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.7",
                            Type = @"Field",
                            Position = @"RF1.7",
                            Name = @"Effective Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date on which the referral is effective.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.7.1",
                            Type = @"Component",
                            Position = @"RF1.7.1",
                            Name = @"Time Of An Event",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.8",
                            Type = @"Field",
                            Position = @"RF1.8",
                            Name = @"Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date on which the referral expires.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.8.1",
                            Type = @"Component",
                            Position = @"RF1.8.1",
                            Name = @"Time Of An Event",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.9",
                            Type = @"Field",
                            Position = @"RF1.9",
                            Name = @"Process Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date on which the referral originated. It is used in cases of retroactive approval.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.9.1",
                            Type = @"Component",
                            Position = @"RF1.9.1",
                            Name = @"Time Of An Event",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.10",
                            Type = @"Field",
                            Position = @"RF1.10",
                            Name = @"Referral Reason",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0336",
                            TableName = @"Referral reason",
                            Description = @"This field contains the reason for which the referral will take place. Refer to user-defined table 0336 - Referral reason for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.10.1",
                            Type = @"Component",
                            Position = @"RF1.10.1",
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
                            Id = @"RF1.10.2",
                            Type = @"Component",
                            Position = @"RF1.10.2",
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
                            Id = @"RF1.10.3",
                            Type = @"Component",
                            Position = @"RF1.10.3",
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
                            Id = @"RF1.10.4",
                            Type = @"Component",
                            Position = @"RF1.10.4",
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
                            Id = @"RF1.10.5",
                            Type = @"Component",
                            Position = @"RF1.10.5",
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
                            Id = @"RF1.10.6",
                            Type = @"Component",
                            Position = @"RF1.10.6",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.11",
                            Type = @"Field",
                            Position = @"RF1.11",
                            Name = @"External Referral Identifier",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an external application's permanent identifier for the referral. That is, this referral identifier does not belong to the application which originated the referral and assigned the originating referral identifier.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RF1.11.1",
                            Type = @"Component",
                            Position = @"RF1.11.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.11.2",
                            Type = @"Component",
                            Position = @"RF1.11.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.11.3",
                            Type = @"Component",
                            Position = @"RF1.11.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RF1.11.4",
                            Type = @"Component",
                            Position = @"RF1.11.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V231SegmentRF1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field referralStatus;

public HL7V231Field ReferralStatus
{
    get
    {
        if (referralStatus != null)
        {
            return referralStatus;
        }

        referralStatus = new HL7V231Field
        {
            field = message[@"RF1"][1],
            Id = @"RF1.1",
            Type = @"Field",
            Position = @"RF1.1",
            Name = @"Referral Status",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0283",
            TableName = @"Referral status",
            Description = @"This field contains the status of the referral as defined by either the referred-to or the referred-by provider. Refer to user-defined table 0283 - Referral status for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (referralStatus.field.FieldRepetitions != null && referralStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referralStatus.Id));
            referralStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(referralStatus, fieldData);
        }

        return referralStatus;
    } 
}

internal HL7V231Field referralPriority;

public HL7V231Field ReferralPriority
{
    get
    {
        if (referralPriority != null)
        {
            return referralPriority;
        }

        referralPriority = new HL7V231Field
        {
            field = message[@"RF1"][2],
            Id = @"RF1.2",
            Type = @"Field",
            Position = @"RF1.2",
            Name = @"Referral Priority",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0280",
            TableName = @"Referral priority",
            Description = @"This field contains the urgency of the referral. Refer to user-defined table 0280 - Referral priority for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (referralPriority.field.FieldRepetitions != null && referralPriority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referralPriority.Id));
            referralPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(referralPriority, fieldData);
        }

        return referralPriority;
    } 
}

internal HL7V231Field referralType;

public HL7V231Field ReferralType
{
    get
    {
        if (referralType != null)
        {
            return referralType;
        }

        referralType = new HL7V231Field
        {
            field = message[@"RF1"][3],
            Id = @"RF1.3",
            Type = @"Field",
            Position = @"RF1.3",
            Name = @"Referral Type",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0281",
            TableName = @"Referral type",
            Description = @"This field contains the type of referral. It is loosely associated with a clinical specialty or type of resource. Refer to user-defined table 0281 - Referraltype for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (referralType.field.FieldRepetitions != null && referralType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referralType.Id));
            referralType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(referralType, fieldData);
        }

        return referralType;
    } 
}

internal HL7V231Field referralDisposition;

public HL7V231Field ReferralDisposition
{
    get
    {
        if (referralDisposition != null)
        {
            return referralDisposition;
        }

        referralDisposition = new HL7V231Field
        {
            field = message[@"RF1"][4],
            Id = @"RF1.4",
            Type = @"Field",
            Position = @"RF1.4",
            Name = @"Referral Disposition",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0282",
            TableName = @"Referral disposition",
            Description = @"This field contains the type of response or action that the referring provider would like from the referred-to provider. Refer to user-defined table 0282 - Referral disposition for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (referralDisposition.field.FieldRepetitions != null && referralDisposition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referralDisposition.Id));
            referralDisposition.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(referralDisposition, fieldData);
        }

        return referralDisposition;
    } 
}

internal HL7V231Field referralCategory;

public HL7V231Field ReferralCategory
{
    get
    {
        if (referralCategory != null)
        {
            return referralCategory;
        }

        referralCategory = new HL7V231Field
        {
            field = message[@"RF1"][5],
            Id = @"RF1.5",
            Type = @"Field",
            Position = @"RF1.5",
            Name = @"Referral Category",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0284",
            TableName = @"Referral category",
            Description = @"This field contains the location at which the referral will take place. Refer to user-defined table 0284 - Referral category for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (referralCategory.field.FieldRepetitions != null && referralCategory.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referralCategory.Id));
            referralCategory.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(referralCategory, fieldData);
        }

        return referralCategory;
    } 
}

internal HL7V231Field originatingReferralIdentifier;

public HL7V231Field OriginatingReferralIdentifier
{
    get
    {
        if (originatingReferralIdentifier != null)
        {
            return originatingReferralIdentifier;
        }

        originatingReferralIdentifier = new HL7V231Field
        {
            field = message[@"RF1"][6],
            Id = @"RF1.6",
            Type = @"Field",
            Position = @"RF1.6",
            Name = @"Originating Referral Identifier",
            Length = 30,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the originating application's permanent identifier for the referral. This is a composite field.",
            Sample = @"",
        };

        // check for repetitions
        if (originatingReferralIdentifier.field.FieldRepetitions != null && originatingReferralIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(originatingReferralIdentifier.Id));
            originatingReferralIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(originatingReferralIdentifier, fieldData);
        }

        return originatingReferralIdentifier;
    } 
}

internal HL7V231Field effectiveDate;

public HL7V231Field EffectiveDate
{
    get
    {
        if (effectiveDate != null)
        {
            return effectiveDate;
        }

        effectiveDate = new HL7V231Field
        {
            field = message[@"RF1"][7],
            Id = @"RF1.7",
            Type = @"Field",
            Position = @"RF1.7",
            Name = @"Effective Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date on which the referral is effective.",
            Sample = @"",
        };

        // check for repetitions
        if (effectiveDate.field.FieldRepetitions != null && effectiveDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(effectiveDate.Id));
            effectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(effectiveDate, fieldData);
        }

        return effectiveDate;
    } 
}

internal HL7V231Field expirationDate;

public HL7V231Field ExpirationDate
{
    get
    {
        if (expirationDate != null)
        {
            return expirationDate;
        }

        expirationDate = new HL7V231Field
        {
            field = message[@"RF1"][8],
            Id = @"RF1.8",
            Type = @"Field",
            Position = @"RF1.8",
            Name = @"Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date on which the referral expires.",
            Sample = @"",
        };

        // check for repetitions
        if (expirationDate.field.FieldRepetitions != null && expirationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(expirationDate.Id));
            expirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(expirationDate, fieldData);
        }

        return expirationDate;
    } 
}

internal HL7V231Field processDate;

public HL7V231Field ProcessDate
{
    get
    {
        if (processDate != null)
        {
            return processDate;
        }

        processDate = new HL7V231Field
        {
            field = message[@"RF1"][9],
            Id = @"RF1.9",
            Type = @"Field",
            Position = @"RF1.9",
            Name = @"Process Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date on which the referral originated. It is used in cases of retroactive approval.",
            Sample = @"",
        };

        // check for repetitions
        if (processDate.field.FieldRepetitions != null && processDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(processDate.Id));
            processDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(processDate, fieldData);
        }

        return processDate;
    } 
}

internal HL7V231Field referralReason;

public HL7V231Field ReferralReason
{
    get
    {
        if (referralReason != null)
        {
            return referralReason;
        }

        referralReason = new HL7V231Field
        {
            field = message[@"RF1"][10],
            Id = @"RF1.10",
            Type = @"Field",
            Position = @"RF1.10",
            Name = @"Referral Reason",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0336",
            TableName = @"Referral reason",
            Description = @"This field contains the reason for which the referral will take place. Refer to user-defined table 0336 - Referral reason for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (referralReason.field.FieldRepetitions != null && referralReason.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referralReason.Id));
            referralReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(referralReason, fieldData);
        }

        return referralReason;
    } 
}

internal HL7V231Field externalReferralIdentifier;

public HL7V231Field ExternalReferralIdentifier
{
    get
    {
        if (externalReferralIdentifier != null)
        {
            return externalReferralIdentifier;
        }

        externalReferralIdentifier = new HL7V231Field
        {
            field = message[@"RF1"][11],
            Id = @"RF1.11",
            Type = @"Field",
            Position = @"RF1.11",
            Name = @"External Referral Identifier",
            Length = 30,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains an external application's permanent identifier for the referral. That is, this referral identifier does not belong to the application which originated the referral and assigned the originating referral identifier.",
            Sample = @"",
        };

        // check for repetitions
        if (externalReferralIdentifier.field.FieldRepetitions != null && externalReferralIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(externalReferralIdentifier.Id));
            externalReferralIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(externalReferralIdentifier, fieldData);
        }

        return externalReferralIdentifier;
    } 
}
    }
}
