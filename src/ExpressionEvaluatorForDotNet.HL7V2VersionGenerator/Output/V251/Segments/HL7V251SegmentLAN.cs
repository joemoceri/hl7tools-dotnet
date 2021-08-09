using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentLAN
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"LAN"; } }

        public string SegmentId { get { return @"LAN"; } }
        
        public string LongName { get { return @"Language Detail"; } }
        
        public string Description { get { return @"The LAN segment adds detailed language information to the staff member identified by the STF segment. An LAN segment may optionally follow an STF segment. An LAN segment must always have been preceded by a corresponding STF segment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

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
                            Id = @"LAN.1",
                            Type = @"Field",
                            Position = @"LAN.1",
                            Name = @"Set ID - LAN",
                            Length = 60,
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
                            Id = @"LAN.2",
                            Type = @"Field",
                            Position = @"LAN.2",
                            Name = @"Language Code",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0296",
                            TableName = @"Primary Language",
                            Description = @"This field contains the language about which the Staff Member's has some knowledge. HL7 recommends using ISO table 639 as the suggested values in User-defined Table 0296 - Language .",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LAN.2.1",
                            Type = @"Component",
                            Position = @"LAN.2.1",
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
                            Id = @"LAN.2.2",
                            Type = @"Component",
                            Position = @"LAN.2.2",
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
                            Id = @"LAN.2.3",
                            Type = @"Component",
                            Position = @"LAN.2.3",
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
                            Id = @"LAN.2.4",
                            Type = @"Component",
                            Position = @"LAN.2.4",
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
                            Id = @"LAN.2.5",
                            Type = @"Component",
                            Position = @"LAN.2.5",
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
                            Id = @"LAN.2.6",
                            Type = @"Component",
                            Position = @"LAN.2.6",
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
                            Id = @"LAN.3",
                            Type = @"Field",
                            Position = @"LAN.3",
                            Name = @"Language Ability Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0403",
                            TableName = @"Language Ability",
                            Description = @"This field contains the ability the Staff Member possesses with respect to the language. HL7 recommends using values in HL7 Table 0403 - Language ability.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LAN.3.1",
                            Type = @"Component",
                            Position = @"LAN.3.1",
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
                            Id = @"LAN.3.2",
                            Type = @"Component",
                            Position = @"LAN.3.2",
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
                            Id = @"LAN.3.3",
                            Type = @"Component",
                            Position = @"LAN.3.3",
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
                            Id = @"LAN.3.4",
                            Type = @"Component",
                            Position = @"LAN.3.4",
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
                            Id = @"LAN.3.5",
                            Type = @"Component",
                            Position = @"LAN.3.5",
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
                            Id = @"LAN.3.6",
                            Type = @"Component",
                            Position = @"LAN.3.6",
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
                            Id = @"LAN.4",
                            Type = @"Field",
                            Position = @"LAN.4",
                            Name = @"Language Proficiency Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0404",
                            TableName = @"Language Proficiency",
                            Description = @"This field contains the level of knowledge the Staff Member possesses with respect to the language ability. HL7 suggests using values in HL7 Table 0404 - Language proficiency .",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LAN.4.1",
                            Type = @"Component",
                            Position = @"LAN.4.1",
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
                            Id = @"LAN.4.2",
                            Type = @"Component",
                            Position = @"LAN.4.2",
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
                            Id = @"LAN.4.3",
                            Type = @"Component",
                            Position = @"LAN.4.3",
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
                            Id = @"LAN.4.4",
                            Type = @"Component",
                            Position = @"LAN.4.4",
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
                            Id = @"LAN.4.5",
                            Type = @"Component",
                            Position = @"LAN.4.5",
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
                            Id = @"LAN.4.6",
                            Type = @"Component",
                            Position = @"LAN.4.6",
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
                        };
            }
        }

        public HL7V251SegmentLAN(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field setIDLAN;

public HL7V251Field SetIDLAN
{
    get
    {
        if (setIDLAN != null)
        {
            return setIDLAN;
        }

        setIDLAN = new HL7V251Field
        {
            field = message[@"LAN"][1],
            Id = @"LAN.1",
            Type = @"Field",
            Position = @"LAN.1",
            Name = @"Set ID - LAN",
            Length = 60,
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
        if (setIDLAN.field.FieldRepetitions != null && setIDLAN.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDLAN.Id));
            setIDLAN.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(setIDLAN, fieldData);
        }

        return setIDLAN;
    } 
}

internal HL7V251Field languageCode;

public HL7V251Field LanguageCode
{
    get
    {
        if (languageCode != null)
        {
            return languageCode;
        }

        languageCode = new HL7V251Field
        {
            field = message[@"LAN"][2],
            Id = @"LAN.2",
            Type = @"Field",
            Position = @"LAN.2",
            Name = @"Language Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0296",
            TableName = @"Primary Language",
            Description = @"This field contains the language about which the Staff Member's has some knowledge. HL7 recommends using ISO table 639 as the suggested values in User-defined Table 0296 - Language .",
            Sample = @"",
        };

        // check for repetitions
        if (languageCode.field.FieldRepetitions != null && languageCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(languageCode.Id));
            languageCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(languageCode, fieldData);
        }

        return languageCode;
    } 
}

internal HL7V251Field languageAbilityCode;

public HL7V251Field LanguageAbilityCode
{
    get
    {
        if (languageAbilityCode != null)
        {
            return languageAbilityCode;
        }

        languageAbilityCode = new HL7V251Field
        {
            field = message[@"LAN"][3],
            Id = @"LAN.3",
            Type = @"Field",
            Position = @"LAN.3",
            Name = @"Language Ability Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0403",
            TableName = @"Language Ability",
            Description = @"This field contains the ability the Staff Member possesses with respect to the language. HL7 recommends using values in HL7 Table 0403 - Language ability.",
            Sample = @"",
        };

        // check for repetitions
        if (languageAbilityCode.field.FieldRepetitions != null && languageAbilityCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(languageAbilityCode.Id));
            languageAbilityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(languageAbilityCode, fieldData);
        }

        return languageAbilityCode;
    } 
}

internal HL7V251Field languageProficiencyCode;

public HL7V251Field LanguageProficiencyCode
{
    get
    {
        if (languageProficiencyCode != null)
        {
            return languageProficiencyCode;
        }

        languageProficiencyCode = new HL7V251Field
        {
            field = message[@"LAN"][4],
            Id = @"LAN.4",
            Type = @"Field",
            Position = @"LAN.4",
            Name = @"Language Proficiency Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0404",
            TableName = @"Language Proficiency",
            Description = @"This field contains the level of knowledge the Staff Member possesses with respect to the language ability. HL7 suggests using values in HL7 Table 0404 - Language proficiency .",
            Sample = @"",
        };

        // check for repetitions
        if (languageProficiencyCode.field.FieldRepetitions != null && languageProficiencyCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(languageProficiencyCode.Id));
            languageProficiencyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(languageProficiencyCode, fieldData);
        }

        return languageProficiencyCode;
    } 
}
    }
}
