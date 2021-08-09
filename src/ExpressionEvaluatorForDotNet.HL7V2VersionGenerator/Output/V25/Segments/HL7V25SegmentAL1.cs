using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentAL1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"AL1"; } }

        public string SegmentId { get { return @"AL1"; } }
        
        public string LongName { get { return @"Patient Allergy Information"; } }
        
        public string Description { get { return @"The AL1 segment contains patient allergy information of various types. Most of this information will be derived from user-defined tables. Each AL1 segment describes a single patient allergy."; } }
        
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
                            Name = @"Set ID - AL1",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.2",
                            Type = @"Field",
                            Position = @"AL1.2",
                            Name = @"Allergen Type Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0127",
                            TableName = @"Allergen Type",
                            Description = @"This field indicates a general allergy category (drug, food, pollen, etc.). Refer to User-defined Table 0127 - Allergen Type for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AL1.2.1",
                            Type = @"Component",
                            Position = @"AL1.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.2.2",
                            Type = @"Component",
                            Position = @"AL1.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.2.3",
                            Type = @"Component",
                            Position = @"AL1.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.2.4",
                            Type = @"Component",
                            Position = @"AL1.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.2.5",
                            Type = @"Component",
                            Position = @"AL1.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.2.6",
                            Type = @"Component",
                            Position = @"AL1.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3",
                            Type = @"Field",
                            Position = @"AL1.3",
                            Name = @"Allergen Code/Mnemonic/Description",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies a particular allergen. This element may conform to some external, standard coding system (that must be identified), or it may conform to local, largely textual or mnemonic descriptions.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AL1.3.1",
                            Type = @"Component",
                            Position = @"AL1.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.2",
                            Type = @"Component",
                            Position = @"AL1.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.3",
                            Type = @"Component",
                            Position = @"AL1.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.4",
                            Type = @"Component",
                            Position = @"AL1.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.5",
                            Type = @"Component",
                            Position = @"AL1.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.3.6",
                            Type = @"Component",
                            Position = @"AL1.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.4",
                            Type = @"Field",
                            Position = @"AL1.4",
                            Name = @"Allergy Severity Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0128",
                            TableName = @"Allergy Severity",
                            Description = @"This field indicates the general severity of the allergy. Refer to User-defined Table 0128 - Allergy Severity for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AL1.4.1",
                            Type = @"Component",
                            Position = @"AL1.4.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.4.2",
                            Type = @"Component",
                            Position = @"AL1.4.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.4.3",
                            Type = @"Component",
                            Position = @"AL1.4.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.4.4",
                            Type = @"Component",
                            Position = @"AL1.4.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.4.5",
                            Type = @"Component",
                            Position = @"AL1.4.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.4.6",
                            Type = @"Component",
                            Position = @"AL1.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AL1.5",
                            Type = @"Field",
                            Position = @"AL1.5",
                            Name = @"Allergy Reaction Code",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the specific allergic reaction that was documented. This element may conform to some external, standard coding system, or it may conform to a local, largely textual or mnemonic descriptions (e.g., convulsions, sneeze, rash, etc.).",
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
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"From V2.4 onward, this field has been retained for backward compatibility only.  This field contains the date that the allergy was identified.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V25SegmentAL1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field setIDAL1;

public HL7V25Field SetIDAL1
{
    get
    {
        if (setIDAL1 != null)
        {
            return setIDAL1;
        }

        setIDAL1 = new HL7V25Field
        {
            field = message[@"AL1"][1],
            Id = @"AL1.1",
            Type = @"Field",
            Position = @"AL1.1",
            Name = @"Set ID - AL1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDAL1.field.FieldRepetitions != null && setIDAL1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDAL1.Id));
            setIDAL1.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(setIDAL1, fieldData);
        }

        return setIDAL1;
    } 
}

internal HL7V25Field allergenTypeCode;

public HL7V25Field AllergenTypeCode
{
    get
    {
        if (allergenTypeCode != null)
        {
            return allergenTypeCode;
        }

        allergenTypeCode = new HL7V25Field
        {
            field = message[@"AL1"][2],
            Id = @"AL1.2",
            Type = @"Field",
            Position = @"AL1.2",
            Name = @"Allergen Type Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0127",
            TableName = @"Allergen Type",
            Description = @"This field indicates a general allergy category (drug, food, pollen, etc.). Refer to User-defined Table 0127 - Allergen Type for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (allergenTypeCode.field.FieldRepetitions != null && allergenTypeCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allergenTypeCode.Id));
            allergenTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(allergenTypeCode, fieldData);
        }

        return allergenTypeCode;
    } 
}

internal HL7V25Field allergenCodeMnemonicDescription;

public HL7V25Field AllergenCodeMnemonicDescription
{
    get
    {
        if (allergenCodeMnemonicDescription != null)
        {
            return allergenCodeMnemonicDescription;
        }

        allergenCodeMnemonicDescription = new HL7V25Field
        {
            field = message[@"AL1"][3],
            Id = @"AL1.3",
            Type = @"Field",
            Position = @"AL1.3",
            Name = @"Allergen Code/Mnemonic/Description",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies a particular allergen. This element may conform to some external, standard coding system (that must be identified), or it may conform to local, largely textual or mnemonic descriptions.",
            Sample = @"",
        };

        // check for repetitions
        if (allergenCodeMnemonicDescription.field.FieldRepetitions != null && allergenCodeMnemonicDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allergenCodeMnemonicDescription.Id));
            allergenCodeMnemonicDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(allergenCodeMnemonicDescription, fieldData);
        }

        return allergenCodeMnemonicDescription;
    } 
}

internal HL7V25Field allergySeverityCode;

public HL7V25Field AllergySeverityCode
{
    get
    {
        if (allergySeverityCode != null)
        {
            return allergySeverityCode;
        }

        allergySeverityCode = new HL7V25Field
        {
            field = message[@"AL1"][4],
            Id = @"AL1.4",
            Type = @"Field",
            Position = @"AL1.4",
            Name = @"Allergy Severity Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0128",
            TableName = @"Allergy Severity",
            Description = @"This field indicates the general severity of the allergy. Refer to User-defined Table 0128 - Allergy Severity for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (allergySeverityCode.field.FieldRepetitions != null && allergySeverityCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allergySeverityCode.Id));
            allergySeverityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(allergySeverityCode, fieldData);
        }

        return allergySeverityCode;
    } 
}

internal HL7V25Field allergyReactionCode;

public HL7V25Field AllergyReactionCode
{
    get
    {
        if (allergyReactionCode != null)
        {
            return allergyReactionCode;
        }

        allergyReactionCode = new HL7V25Field
        {
            field = message[@"AL1"][5],
            Id = @"AL1.5",
            Type = @"Field",
            Position = @"AL1.5",
            Name = @"Allergy Reaction Code",
            Length = 15,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the specific allergic reaction that was documented. This element may conform to some external, standard coding system, or it may conform to a local, largely textual or mnemonic descriptions (e.g., convulsions, sneeze, rash, etc.).",
            Sample = @"",
        };

        // check for repetitions
        if (allergyReactionCode.field.FieldRepetitions != null && allergyReactionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allergyReactionCode.Id));
            allergyReactionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(allergyReactionCode, fieldData);
        }

        return allergyReactionCode;
    } 
}

internal HL7V25Field identificationDate;

public HL7V25Field IdentificationDate
{
    get
    {
        if (identificationDate != null)
        {
            return identificationDate;
        }

        identificationDate = new HL7V25Field
        {
            field = message[@"AL1"][6],
            Id = @"AL1.6",
            Type = @"Field",
            Position = @"AL1.6",
            Name = @"Identification Date",
            Length = 8,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"From V2.4 onward, this field has been retained for backward compatibility only.  This field contains the date that the allergy was identified.",
            Sample = @"",
        };

        // check for repetitions
        if (identificationDate.field.FieldRepetitions != null && identificationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(identificationDate.Id));
            identificationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(identificationDate, fieldData);
        }

        return identificationDate;
    } 
}
    }
}
