using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentODS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ODS"; } }

        public string SegmentId { get { return @"ODS"; } }
        
        public string LongName { get { return @"Dietary Orders, Supplements, and Preferences"; } }
        
        public string Description { get { return @"The ORC sequence items of interest to ODS are ORC-1-order control, ORC-2-placer order number, ORC-3-filler order number, ORC-7-quantity/timing, ORC-9-date/time of transaction, ORC-10-entered by, and ORC-11-verified by. For ORC-1-order control, the values may be New (NW), Cancel (CA), Discontinue Order Request (DC), Change (XO), Hold Order Request (HD), and Release Previous Hold (RL). The HD and RL codes could stop service for a specified length of time. ORC-7-quantity/timing should be used to specify whether an order is continuous or for one service period only. It is also useful for supplements which are part of a diet but only delivered, say, every day at night."; } }
        
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
                            TableName = @"Diet Code Specification Type",
                            Description = @"This field specifies type of diet. Refer To HL7 Table 0159 - Diet Code Specification Type for valid entries.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.2",
                            Type = @"Field",
                            Position = @"ODS.2",
                            Name = @"Service Period",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"10",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"When blank, the modifier applies to all service periods. Diet orders, for example, typically apply to all service periods. This field usually specifies supplements. This field allows you to designate a modification for one or more of the service periods during a day by combining service specifications as needed. The service periods will be local CEs, normally numbers. Suggested are:

service 1	is	breakfast
service 2	is	mid-morning snack
service 3	is	lunch
service 4	is	mid-afternoon snack
service 5	is	dinner
service 6	is	bedtime snack

Ex: |1~5| means service 1 and service 5, whatever these are locally defined to be.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ODS.2.1",
                            Type = @"Component",
                            Position = @"ODS.2.1",
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
                            Id = @"ODS.2.2",
                            Type = @"Component",
                            Position = @"ODS.2.2",
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
                            Id = @"ODS.2.3",
                            Type = @"Component",
                            Position = @"ODS.2.3",
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
                            Id = @"ODS.2.4",
                            Type = @"Component",
                            Position = @"ODS.2.4",
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
                            Id = @"ODS.2.5",
                            Type = @"Component",
                            Position = @"ODS.2.5",
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
                            Id = @"ODS.2.6",
                            Type = @"Component",
                            Position = @"ODS.2.6",
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
                            Id = @"ODS.2.7",
                            Type = @"Component",
                            Position = @"ODS.2.7",
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
                            Id = @"ODS.2.8",
                            Type = @"Component",
                            Position = @"ODS.2.8",
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
                            Id = @"ODS.2.9",
                            Type = @"Component",
                            Position = @"ODS.2.9",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODS.3",
                            Type = @"Field",
                            Position = @"ODS.3",
                            Name = @"Diet, Supplement, or Preference Code",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"20",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the identifier of the ordered item for a patient; it is equivalent to OBR-4-universal service ID in function. Since ODS is a repeating segment, multiple entities get multiple segments. Example:

|^REG|, |023^^99FD6|, |^NOLACT|, |^TUBEFD|, and |011^HIPRO100^99FD1~123^LOFAT20^99FD1|",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ODS.3.1",
                            Type = @"Component",
                            Position = @"ODS.3.1",
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
                            Id = @"ODS.3.2",
                            Type = @"Component",
                            Position = @"ODS.3.2",
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
                            Id = @"ODS.3.3",
                            Type = @"Component",
                            Position = @"ODS.3.3",
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
                            Id = @"ODS.3.4",
                            Type = @"Component",
                            Position = @"ODS.3.4",
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
                            Id = @"ODS.3.5",
                            Type = @"Component",
                            Position = @"ODS.3.5",
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
                            Id = @"ODS.3.6",
                            Type = @"Component",
                            Position = @"ODS.3.6",
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
                            Id = @"ODS.3.7",
                            Type = @"Component",
                            Position = @"ODS.3.7",
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
                            Id = @"ODS.3.8",
                            Type = @"Component",
                            Position = @"ODS.3.8",
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
                            Id = @"ODS.3.9",
                            Type = @"Component",
                            Position = @"ODS.3.9",
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
                            Description = @"This field defines the specific instructions for dietary. These instructions may address specific patient needs, such as isolation. This field provides the ordering provider's dietary instructions as free text. It can represent the full dietary instruction or indicate supplemental information.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentODS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field type;

public HL7V26Field Type
{
    get
    {
        if (type != null)
        {
            return type;
        }

        type = new HL7V26Field
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
            TableName = @"Diet Code Specification Type",
            Description = @"This field specifies type of diet. Refer To HL7 Table 0159 - Diet Code Specification Type for valid entries.",
            Sample = @"",
        };

        

        

        

        return type;
    } 
}
internal HL7V26Field servicePeriod;

public HL7V26Field ServicePeriod
{
    get
    {
        if (servicePeriod != null)
        {
            return servicePeriod;
        }

        servicePeriod = new HL7V26Field
        {
            field = message[@"ODS"][2],
            Id = @"ODS.2",
            Type = @"Field",
            Position = @"ODS.2",
            Name = @"Service Period",
            Length = 250,
            Usage = @"O",
            Rpt = @"10",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"When blank, the modifier applies to all service periods. Diet orders, for example, typically apply to all service periods. This field usually specifies supplements. This field allows you to designate a modification for one or more of the service periods during a day by combining service specifications as needed. The service periods will be local CEs, normally numbers. Suggested are:

service 1	is	breakfast
service 2	is	mid-morning snack
service 3	is	lunch
service 4	is	mid-afternoon snack
service 5	is	dinner
service 6	is	bedtime snack

Ex: |1~5| means service 1 and service 5, whatever these are locally defined to be.",
            Sample = @"",
        };

        

        

        

        return servicePeriod;
    } 
}
internal HL7V26Field diet,Supplement,orPreferenceCode;

public HL7V26Field Diet,Supplement,orPreferenceCode
{
    get
    {
        if (diet,Supplement,orPreferenceCode != null)
        {
            return diet,Supplement,orPreferenceCode;
        }

        diet,Supplement,orPreferenceCode = new HL7V26Field
        {
            field = message[@"ODS"][3],
            Id = @"ODS.3",
            Type = @"Field",
            Position = @"ODS.3",
            Name = @"Diet, Supplement, or Preference Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"20",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field is the identifier of the ordered item for a patient; it is equivalent to OBR-4-universal service ID in function. Since ODS is a repeating segment, multiple entities get multiple segments. Example:

|^REG|, |023^^99FD6|, |^NOLACT|, |^TUBEFD|, and |011^HIPRO100^99FD1~123^LOFAT20^99FD1|",
            Sample = @"",
        };

        

        

        

        return diet,Supplement,orPreferenceCode;
    } 
}
internal HL7V26Field textInstruction;

public HL7V26Field TextInstruction
{
    get
    {
        if (textInstruction != null)
        {
            return textInstruction;
        }

        textInstruction = new HL7V26Field
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
            Description = @"This field defines the specific instructions for dietary. These instructions may address specific patient needs, such as isolation. This field provides the ordering provider's dietary instructions as free text. It can represent the full dietary instruction or indicate supplemental information.",
            Sample = @"",
        };

        

        

        

        return textInstruction;
    } 
}

    }
}
