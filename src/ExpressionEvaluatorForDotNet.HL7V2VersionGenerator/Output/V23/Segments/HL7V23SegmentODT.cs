using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentODT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ODT"; } }

        public string SegmentId { get { return @"ODT"; } }
        
        public string LongName { get { return @"Diet tray instructions segment"; } }
        
        public string Description { get { return @"This segment addresses tray instructions.  These are independent of diet codes, supplements, and preferences and therefore get separate order numbers"; } }
        
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
                            Id = @"ODT.1",
                            Type = @"Field",
                            Position = @"ODT.1",
                            Name = @"Tray Type",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0160",
                            TableName = @"Tray type",
                            Description = @"This field defines the type of dietary tray.  Refer to HL7 table 0160 - Tray type for valid entries

Tray specifications are useful for early and late tray delivery in cases where a patient undergoes a procedure during normal feeding times.  Tray specifications can also be used for guest trays, no trays, and messages.  The value MSG means the ODT segment does not specify the type of tray but provides additional information about an existing tray.  This information is found in ODT-3-text instructions",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ODT.1.1",
                            Type = @"Component",
                            Position = @"ODT.1.1",
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
                            Id = @"ODT.1.2",
                            Type = @"Component",
                            Position = @"ODT.1.2",
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
                            Id = @"ODT.1.3",
                            Type = @"Component",
                            Position = @"ODT.1.3",
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
                            Id = @"ODT.1.4",
                            Type = @"Component",
                            Position = @"ODT.1.4",
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
                            Id = @"ODT.1.5",
                            Type = @"Component",
                            Position = @"ODT.1.5",
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
                            Id = @"ODT.1.6",
                            Type = @"Component",
                            Position = @"ODT.1.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ODT.2",
                            Type = @"Field",
                            Position = @"ODT.2",
                            Name = @"Service Period",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"10",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"When blank, the modifier applies to all service periods.  This field allows you to designate one or more of the feeding periods during a day by combining the codes as needed.  It can also combine with quantity/timing to give such information as which service period the order belongs with. This field is identical in meaning with ODS-2-service period.  See Section 4.6.1.2, “Service period  (CE)   00270,” for further details",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ODT.2.1",
                            Type = @"Component",
                            Position = @"ODT.2.1",
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
                            Id = @"ODT.2.2",
                            Type = @"Component",
                            Position = @"ODT.2.2",
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
                            Id = @"ODT.2.3",
                            Type = @"Component",
                            Position = @"ODT.2.3",
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
                            Id = @"ODT.2.4",
                            Type = @"Component",
                            Position = @"ODT.2.4",
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
                            Id = @"ODT.2.5",
                            Type = @"Component",
                            Position = @"ODT.2.5",
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
                            Id = @"ODT.2.6",
                            Type = @"Component",
                            Position = @"ODT.2.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field defines instructions associated with the tray",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentODT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field trayType;

public HL7V23Field TrayType
{
    get
    {
        if (trayType != null)
        {
            return trayType;
        }

        trayType = new HL7V23Field
        {
            field = message[@"ODT"][1],
            Id = @"ODT.1",
            Type = @"Field",
            Position = @"ODT.1",
            Name = @"Tray Type",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0160",
            TableName = @"Tray type",
            Description = @"This field defines the type of dietary tray.  Refer to HL7 table 0160 - Tray type for valid entries

Tray specifications are useful for early and late tray delivery in cases where a patient undergoes a procedure during normal feeding times.  Tray specifications can also be used for guest trays, no trays, and messages.  The value MSG means the ODT segment does not specify the type of tray but provides additional information about an existing tray.  This information is found in ODT-3-text instructions",
            Sample = @"",
        };

        // check for repetitions
        if (trayType.field.FieldRepetitions != null && trayType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(trayType.Id));
            trayType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(trayType, fieldData);
        }

        return trayType;
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
            field = message[@"ODT"][2],
            Id = @"ODT.2",
            Type = @"Field",
            Position = @"ODT.2",
            Name = @"Service Period",
            Length = 60,
            Usage = @"O",
            Rpt = @"10",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"When blank, the modifier applies to all service periods.  This field allows you to designate one or more of the feeding periods during a day by combining the codes as needed.  It can also combine with quantity/timing to give such information as which service period the order belongs with. This field is identical in meaning with ODS-2-service period.  See Section 4.6.1.2, “Service period  (CE)   00270,” for further details",
            Sample = @"",
        };

        // check for repetitions
        if (servicePeriod.field.FieldRepetitions != null && servicePeriod.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(servicePeriod.Id));
            servicePeriod.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(servicePeriod, fieldData);
        }

        return servicePeriod;
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
            field = message[@"ODT"][3],
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
            Description = @"This field defines instructions associated with the tray",
            Sample = @"",
        };

        // check for repetitions
        if (textInstruction.field.FieldRepetitions != null && textInstruction.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(textInstruction.Id));
            textInstruction.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(textInstruction, fieldData);
        }

        return textInstruction;
    } 
}
    }
}
