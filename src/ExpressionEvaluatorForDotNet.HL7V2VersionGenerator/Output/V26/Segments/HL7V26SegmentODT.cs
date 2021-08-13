using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentODT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ODT"; } }

        public string SegmentId { get { return @"ODT"; } }
        
        public string LongName { get { return @"Diet Tray Instructions"; } }
        
        public string Description { get { return @"This segment addresses tray instructions. These are independent of diet codes, supplements, and preferences and therefore get separate order numbers."; } }
        
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

        public HL7V26SegmentODT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _trayType;

public HL7V26Field TrayType
{
    get
    {
        if (_trayType != null)
        {
            return _trayType;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ODT.1",
            Type = @"Field",
            Position = @"ODT.1",
            Name = @"Tray Type",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0160",
            TableName = @"Tray Type",
            Description = @"This field defines the type of dietary tray. Refer To HL7 Table 0160 - Tray Type for valid entries.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ODT.1.1",
                            Type = @"Component",
                            Position = @"ODT.1.1",
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
                            Id = @"ODT.1.2",
                            Type = @"Component",
                            Position = @"ODT.1.2",
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
                            Id = @"ODT.1.3",
                            Type = @"Component",
                            Position = @"ODT.1.3",
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
                            Id = @"ODT.1.4",
                            Type = @"Component",
                            Position = @"ODT.1.4",
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
                            Id = @"ODT.1.5",
                            Type = @"Component",
                            Position = @"ODT.1.5",
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
                            Id = @"ODT.1.6",
                            Type = @"Component",
                            Position = @"ODT.1.6",
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
                            Id = @"ODT.1.7",
                            Type = @"Component",
                            Position = @"ODT.1.7",
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
                            Id = @"ODT.1.8",
                            Type = @"Component",
                            Position = @"ODT.1.8",
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
                            Id = @"ODT.1.9",
                            Type = @"Component",
                            Position = @"ODT.1.9",
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
                        }
        }

        _trayType = new HL7V26Field
        {
            field = message[@"ODT"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_trayType.field.FieldRepetitions != null && _trayType.field.FieldRepetitions.Count > 0)
        {
            _trayType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_trayType, fieldData);
        }

        return _trayType;
    } 
}

internal HL7V26Field _servicePeriod;

public HL7V26Field ServicePeriod
{
    get
    {
        if (_servicePeriod != null)
        {
            return _servicePeriod;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ODT.2",
            Type = @"Field",
            Position = @"ODT.2",
            Name = @"Service Period",
            Length = 250,
            Usage = @"O",
            Rpt = @"10",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"When blank, the modifier applies to all service periods. This field allows you to designate one or more of the feeding periods during a day by combining the codes as needed. It can also combine with quantity/timing to give such information as which service period the order belongs with. This field is identical in meaning with ODS-2-service period. See section 4.8.1.2, "" ODS-2 Service Period (CWE) 00270,"" for further details.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ODT.2.1",
                            Type = @"Component",
                            Position = @"ODT.2.1",
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
                            Id = @"ODT.2.2",
                            Type = @"Component",
                            Position = @"ODT.2.2",
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
                            Id = @"ODT.2.3",
                            Type = @"Component",
                            Position = @"ODT.2.3",
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
                            Id = @"ODT.2.4",
                            Type = @"Component",
                            Position = @"ODT.2.4",
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
                            Id = @"ODT.2.5",
                            Type = @"Component",
                            Position = @"ODT.2.5",
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
                            Id = @"ODT.2.6",
                            Type = @"Component",
                            Position = @"ODT.2.6",
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
                            Id = @"ODT.2.7",
                            Type = @"Component",
                            Position = @"ODT.2.7",
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
                            Id = @"ODT.2.8",
                            Type = @"Component",
                            Position = @"ODT.2.8",
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
                            Id = @"ODT.2.9",
                            Type = @"Component",
                            Position = @"ODT.2.9",
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
                        }
        }

        _servicePeriod = new HL7V26Field
        {
            field = message[@"ODT"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_servicePeriod.field.FieldRepetitions != null && _servicePeriod.field.FieldRepetitions.Count > 0)
        {
            _servicePeriod.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_servicePeriod, fieldData);
        }

        return _servicePeriod;
    } 
}

internal HL7V26Field _textInstruction;

public HL7V26Field TextInstruction
{
    get
    {
        if (_textInstruction != null)
        {
            return _textInstruction;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"ODT.3",
            Type = @"Field",
            Position = @"ODT.3",
            Name = @"Text Instruction",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field defines instructions associated with the tray. Example:

|PLASTIC SILVERWARE|.",
            Sample = @"",
            Fields = null
        }

        _textInstruction = new HL7V26Field
        {
            field = message[@"ODT"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_textInstruction.field.FieldRepetitions != null && _textInstruction.field.FieldRepetitions.Count > 0)
        {
            _textInstruction.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_textInstruction, fieldData);
        }

        return _textInstruction;
    } 
}
    }
}
