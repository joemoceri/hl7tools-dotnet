using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentODS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ODS"; } }

        public string SegmentId { get { return @"ODS"; } }
        
        public string LongName { get { return @"Dietary orders, supplements, and preferences"; } }
        
        public string Description { get { return @"The ORC sequence items of interest to ODS are ORC-1-order control,ORC-2-placer order number, ORC-3filler order number, ORC-7-quantity/timing, ORC-9-date/time of transaction, ORC-10-entered by, and ORC-11-verified by.  For ORC-1-order control, the values may be New (NW), Cancel (CA), Discontinue Order Request (DC), Change (XO), Hold Order Request (HD), and Release Previous Hold (RL).  The HD and RL codes could stop service for a specified length of time.  ORC-4-quantity/timing should be used to specify whether an order is continuous or for one service period only.  It is also useful for supplements which are part of a diet but only delivered, say, every day at night."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
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
                            Id = @"ODS.1",
                            Type = @"Field",
                            Position = @"ODS.1",
                            Name = @"Type",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0159",
                            TableName = @"Diet code specification type",
                            Description = @"This field specifies type of diet.  Refer to HL7 table 0159 - Diet type for valid entries",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.2",
                            Type = @"Field",
                            Position = @"ODS.2",
                            Name = @"Service Period",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"10",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"When blank, the modifier applies to all service periods.  Diet orders, for example, typically apply to all service periods.  This field usually specifies supplements.  This field allows you to designate a modification for one or more of the service periods during a day by combining service specifications as needed.  The service periods will be local CEs, normally numbers",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ODS.2.1",
                            Type = @"Component",
                            Position = @"ODS.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.2.2",
                            Type = @"Component",
                            Position = @"ODS.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.2.3",
                            Type = @"Component",
                            Position = @"ODS.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.2.4",
                            Type = @"Component",
                            Position = @"ODS.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.2.5",
                            Type = @"Component",
                            Position = @"ODS.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.2.6",
                            Type = @"Component",
                            Position = @"ODS.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.3",
                            Type = @"Field",
                            Position = @"ODS.3",
                            Name = @"Diet, Supplement, or Preference Code",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"20",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the identifier of the ordered item for a patient; it is equivalent to OBR-4-universal service ID in function.  Since ODS is a repeating segment, multiple entities get multiple segments",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ODS.3.1",
                            Type = @"Component",
                            Position = @"ODS.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.3.2",
                            Type = @"Component",
                            Position = @"ODS.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.3.3",
                            Type = @"Component",
                            Position = @"ODS.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.3.4",
                            Type = @"Component",
                            Position = @"ODS.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.3.5",
                            Type = @"Component",
                            Position = @"ODS.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.3.6",
                            Type = @"Component",
                            Position = @"ODS.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.4",
                            Type = @"Field",
                            Position = @"ODS.4",
                            Name = @"Text Instruction",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"2",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field defines the specific instructions for dietary.  These instructions may address specific patient needs, such as isolation.  This field provides the ordering provider’s dietary instructions as free text. It can represent the full dietary instruction or indicate supplemental information.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentODS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field type;

public HL7V23Field Type
{
    get
    {
        if (type != null)
        {
            return type;
        }

        type = new HL7V23Field
        {
            field = message[@"ODS"][1],
            Id = @"ODS.1",
            Type = @"Field",
            Position = @"ODS.1",
            Name = @"Type",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0159",
            TableName = @"Diet code specification type",
            Description = @"This field specifies type of diet.  Refer to HL7 table 0159 - Diet type for valid entries",
            Sample = @"",
        };

        

        

        

        return type;
    } 
}
internal HL7V23Field servicePeriod;

public HL7V23Field ServicePeriod
{
    get
    {
        if (servicePeriod != null)
        {
            return servicePeriod;
        }

        servicePeriod = new HL7V23Field
        {
            field = message[@"ODS"][2],
            Id = @"ODS.2",
            Type = @"Field",
            Position = @"ODS.2",
            Name = @"Service Period",
            Length = 60,
            Usage = @"O",
            Rpt = @"10",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"When blank, the modifier applies to all service periods.  Diet orders, for example, typically apply to all service periods.  This field usually specifies supplements.  This field allows you to designate a modification for one or more of the service periods during a day by combining service specifications as needed.  The service periods will be local CEs, normally numbers",
            Sample = @"",
        };

        

        

        

        return servicePeriod;
    } 
}
internal HL7V23Field diet,Supplement,orPreferenceCode;

public HL7V23Field Diet,Supplement,orPreferenceCode
{
    get
    {
        if (diet,Supplement,orPreferenceCode != null)
        {
            return diet,Supplement,orPreferenceCode;
        }

        diet,Supplement,orPreferenceCode = new HL7V23Field
        {
            field = message[@"ODS"][3],
            Id = @"ODS.3",
            Type = @"Field",
            Position = @"ODS.3",
            Name = @"Diet, Supplement, or Preference Code",
            Length = 60,
            Usage = @"R",
            Rpt = @"20",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the identifier of the ordered item for a patient; it is equivalent to OBR-4-universal service ID in function.  Since ODS is a repeating segment, multiple entities get multiple segments",
            Sample = @"",
        };

        

        

        

        return diet,Supplement,orPreferenceCode;
    } 
}
internal HL7V23Field textInstruction;

public HL7V23Field TextInstruction
{
    get
    {
        if (textInstruction != null)
        {
            return textInstruction;
        }

        textInstruction = new HL7V23Field
        {
            field = message[@"ODS"][4],
            Id = @"ODS.4",
            Type = @"Field",
            Position = @"ODS.4",
            Name = @"Text Instruction",
            Length = 80,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field defines the specific instructions for dietary.  These instructions may address specific patient needs, such as isolation.  This field provides the ordering provider’s dietary instructions as free text. It can represent the full dietary instruction or indicate supplemental information.",
            Sample = @"",
        };

        

        

        

        return textInstruction;
    } 
}

    }
}
