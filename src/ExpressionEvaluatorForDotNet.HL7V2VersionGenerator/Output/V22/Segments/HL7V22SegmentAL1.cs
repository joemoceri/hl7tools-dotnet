using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentAL1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"AL1"; } }

        public string SegmentId { get { return @"AL1"; } }
        
        public string LongName { get { return @"Patient Allergy Information"; } }
        
        public string Description { get { return @"The AL1 segment contains patient allergy information of various types.  Most of this information will be derived from user-defined tables.  Each AL1 segment describes a single patient allergy"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

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
                            Id = @"AL1.1",
                            Type = @"Field",
                            Position = @"AL1.1",
                            Name = @"Set Id - Allergy",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"number that uniquely identifies the individual transaction for adding, deleting or updating an allergy description in the patient's record.  For those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.  For example, the swap and query transactions allow for multiple PID segments would have Set ID values of 1, 2, then 3, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.2",
                            Type = @"Field",
                            Position = @"AL1.2",
                            Name = @"Allergy Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0127",
                            TableName = @"ALLERGY TYPE",
                            Description = @"indicates a general allergy category (drug, food, pollen, etc.). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3",
                            Type = @"Field",
                            Position = @"AL1.3",
                            Name = @"Allergy Code / Mnemonic / Description",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"uniquely identifies a particular allergy.  This element may conform to some external, standard coding system (which must be identified), or it may conform to local, largely textual or mnemonic descriptions",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AL1.3.1",
                            Type = @"Component",
                            Position = @"AL1.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.2",
                            Type = @"Component",
                            Position = @"AL1.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.3",
                            Type = @"Component",
                            Position = @"AL1.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.4",
                            Type = @"Component",
                            Position = @"AL1.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.5",
                            Type = @"Component",
                            Position = @"AL1.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.6",
                            Type = @"Component",
                            Position = @"AL1.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.4",
                            Type = @"Field",
                            Position = @"AL1.4",
                            Name = @"Allergy Severity",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0128",
                            TableName = @"ALLERGY SEVERITY",
                            Description = @"indicates the general severity of the allergy (severe, moderate, mild, etc.). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.5",
                            Type = @"Field",
                            Position = @"AL1.5",
                            Name = @"Allergy Reaction",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"short, textual description of the specific allergy reaction (convulsions, sneeze, rash, etc.). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.6",
                            Type = @"Field",
                            Position = @"AL1.6",
                            Name = @"Identification Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"date the allergy was identified.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentAL1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdAllergy;

public HL7V22Field SetIdAllergy
{
    get
    {
        if (setIdAllergy != null)
        {
            return setIdAllergy;
        }

        setIdAllergy = new HL7V22Field
        {
            field = message[@"AL1"][1],
            Id = @"AL1.1",
            Type = @"Field",
            Position = @"AL1.1",
            Name = @"Set Id - Allergy",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"number that uniquely identifies the individual transaction for adding, deleting or updating an allergy description in the patient's record.  For those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.  For example, the swap and query transactions allow for multiple PID segments would have Set ID values of 1, 2, then 3, etc",
            Sample = @"",
        };

        // check for repetitions
        if (setIdAllergy.field.FieldRepetitions != null && setIdAllergy.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdAllergy.Id));
            setIdAllergy.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(setIdAllergy, fieldData);
        }

        return setIdAllergy;
    } 
}

internal HL7V22Field allergyType;

public HL7V22Field AllergyType
{
    get
    {
        if (allergyType != null)
        {
            return allergyType;
        }

        allergyType = new HL7V22Field
        {
            field = message[@"AL1"][2],
            Id = @"AL1.2",
            Type = @"Field",
            Position = @"AL1.2",
            Name = @"Allergy Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0127",
            TableName = @"ALLERGY TYPE",
            Description = @"indicates a general allergy category (drug, food, pollen, etc.). ",
            Sample = @"",
        };

        // check for repetitions
        if (allergyType.field.FieldRepetitions != null && allergyType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allergyType.Id));
            allergyType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(allergyType, fieldData);
        }

        return allergyType;
    } 
}

internal HL7V22Field allergyCodeMnemonicDescription;

public HL7V22Field AllergyCodeMnemonicDescription
{
    get
    {
        if (allergyCodeMnemonicDescription != null)
        {
            return allergyCodeMnemonicDescription;
        }

        allergyCodeMnemonicDescription = new HL7V22Field
        {
            field = message[@"AL1"][3],
            Id = @"AL1.3",
            Type = @"Field",
            Position = @"AL1.3",
            Name = @"Allergy Code / Mnemonic / Description",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies a particular allergy.  This element may conform to some external, standard coding system (which must be identified), or it may conform to local, largely textual or mnemonic descriptions",
            Sample = @"",
        };

        // check for repetitions
        if (allergyCodeMnemonicDescription.field.FieldRepetitions != null && allergyCodeMnemonicDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allergyCodeMnemonicDescription.Id));
            allergyCodeMnemonicDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(allergyCodeMnemonicDescription, fieldData);
        }

        return allergyCodeMnemonicDescription;
    } 
}

internal HL7V22Field allergySeverity;

public HL7V22Field AllergySeverity
{
    get
    {
        if (allergySeverity != null)
        {
            return allergySeverity;
        }

        allergySeverity = new HL7V22Field
        {
            field = message[@"AL1"][4],
            Id = @"AL1.4",
            Type = @"Field",
            Position = @"AL1.4",
            Name = @"Allergy Severity",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0128",
            TableName = @"ALLERGY SEVERITY",
            Description = @"indicates the general severity of the allergy (severe, moderate, mild, etc.). ",
            Sample = @"",
        };

        // check for repetitions
        if (allergySeverity.field.FieldRepetitions != null && allergySeverity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allergySeverity.Id));
            allergySeverity.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(allergySeverity, fieldData);
        }

        return allergySeverity;
    } 
}

internal HL7V22Field allergyReaction;

public HL7V22Field AllergyReaction
{
    get
    {
        if (allergyReaction != null)
        {
            return allergyReaction;
        }

        allergyReaction = new HL7V22Field
        {
            field = message[@"AL1"][5],
            Id = @"AL1.5",
            Type = @"Field",
            Position = @"AL1.5",
            Name = @"Allergy Reaction",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"short, textual description of the specific allergy reaction (convulsions, sneeze, rash, etc.). ",
            Sample = @"",
        };

        // check for repetitions
        if (allergyReaction.field.FieldRepetitions != null && allergyReaction.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allergyReaction.Id));
            allergyReaction.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(allergyReaction, fieldData);
        }

        return allergyReaction;
    } 
}

internal HL7V22Field identificationDate;

public HL7V22Field IdentificationDate
{
    get
    {
        if (identificationDate != null)
        {
            return identificationDate;
        }

        identificationDate = new HL7V22Field
        {
            field = message[@"AL1"][6],
            Id = @"AL1.6",
            Type = @"Field",
            Position = @"AL1.6",
            Name = @"Identification Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date the allergy was identified.",
            Sample = @"",
        };

        // check for repetitions
        if (identificationDate.field.FieldRepetitions != null && identificationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(identificationDate.Id));
            identificationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(identificationDate, fieldData);
        }

        return identificationDate;
    } 
}
    }
}
