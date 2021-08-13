using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentSAC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SAC"; } }

        public string SegmentId { get { return @"SAC"; } }
        
        public string LongName { get { return @"Specimen Container detail"; } }
        
        public string Description { get { return @"The container detail segment is the data necessary to maintain the containers that are being used throughout the Laboratory Automation System."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

                    };
            }
        }

        public HL7V251SegmentSAC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _externalAccessionIdentifier;

public HL7V251Field ExternalAccessionIdentifier
{
    get
    {
        if (_externalAccessionIdentifier != null)
        {
            return _externalAccessionIdentifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.1",
            Type = @"Field",
            Position = @"SAC.1",
            Name = @"External Accession Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the laboratory accession. This identifier is assigned by the external laboratory information system.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.1.1",
                            Type = @"Component",
                            Position = @"SAC.1.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.1.2",
                            Type = @"Component",
                            Position = @"SAC.1.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.1.3",
                            Type = @"Component",
                            Position = @"SAC.1.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SAC.1.4",
                            Type = @"Component",
                            Position = @"SAC.1.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _externalAccessionIdentifier = new HL7V251Field
        {
            field = message[@"SAC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_externalAccessionIdentifier.field.FieldRepetitions != null && _externalAccessionIdentifier.field.FieldRepetitions.Count > 0)
        {
            _externalAccessionIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_externalAccessionIdentifier, fieldData);
        }

        return _externalAccessionIdentifier;
    } 
}

internal HL7V251Field _accessionIdentifier;

public HL7V251Field AccessionIdentifier
{
    get
    {
        if (_accessionIdentifier != null)
        {
            return _accessionIdentifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.2",
            Type = @"Field",
            Position = @"SAC.2",
            Name = @"Accession Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the laboratory accession. This identifier is assigned by the information system of the laboratory performing the tests.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.2.1",
                            Type = @"Component",
                            Position = @"SAC.2.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.2.2",
                            Type = @"Component",
                            Position = @"SAC.2.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.2.3",
                            Type = @"Component",
                            Position = @"SAC.2.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SAC.2.4",
                            Type = @"Component",
                            Position = @"SAC.2.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _accessionIdentifier = new HL7V251Field
        {
            field = message[@"SAC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accessionIdentifier.field.FieldRepetitions != null && _accessionIdentifier.field.FieldRepetitions.Count > 0)
        {
            _accessionIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_accessionIdentifier, fieldData);
        }

        return _accessionIdentifier;
    } 
}

internal HL7V251Field _containerIdentifier;

public HL7V251Field ContainerIdentifier
{
    get
    {
        if (_containerIdentifier != null)
        {
            return _containerIdentifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.3",
            Type = @"Field",
            Position = @"SAC.3",
            Name = @"Container Identifier",
            Length = 80,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the container. This field is the container's unique identifier assigned by the corresponding equipment. A container may contain the primary (original) specimen or an aliquot (secondary sample) of that specimen. For primary sample this field contains Primary Container ID; for bar-coded aliquot samples this field contains Aliquot Container ID; for non-bar-coded aliquot samples (e.g., microtiter plate) this field is empty.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.3.1",
                            Type = @"Component",
                            Position = @"SAC.3.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.3.2",
                            Type = @"Component",
                            Position = @"SAC.3.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.3.3",
                            Type = @"Component",
                            Position = @"SAC.3.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SAC.3.4",
                            Type = @"Component",
                            Position = @"SAC.3.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _containerIdentifier = new HL7V251Field
        {
            field = message[@"SAC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerIdentifier.field.FieldRepetitions != null && _containerIdentifier.field.FieldRepetitions.Count > 0)
        {
            _containerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_containerIdentifier, fieldData);
        }

        return _containerIdentifier;
    } 
}

internal HL7V251Field _primaryparentContainerIdentifier;

public HL7V251Field PrimaryparentContainerIdentifier
{
    get
    {
        if (_primaryparentContainerIdentifier != null)
        {
            return _primaryparentContainerIdentifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.4",
            Type = @"Field",
            Position = @"SAC.4",
            Name = @"Primary (parent) Container Identifier ",
            Length = 80,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"If this field is filled in, it identifies the primary container from which this specimen came. For primary samples this field is empty; for aliquot samples this field should contain the identifier of primary container.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.4.1",
                            Type = @"Component",
                            Position = @"SAC.4.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.4.2",
                            Type = @"Component",
                            Position = @"SAC.4.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.4.3",
                            Type = @"Component",
                            Position = @"SAC.4.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SAC.4.4",
                            Type = @"Component",
                            Position = @"SAC.4.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _primaryparentContainerIdentifier = new HL7V251Field
        {
            field = message[@"SAC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryparentContainerIdentifier.field.FieldRepetitions != null && _primaryparentContainerIdentifier.field.FieldRepetitions.Count > 0)
        {
            _primaryparentContainerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_primaryparentContainerIdentifier, fieldData);
        }

        return _primaryparentContainerIdentifier;
    } 
}

internal HL7V251Field _equipmentContainerIdentifier;

public HL7V251Field EquipmentContainerIdentifier
{
    get
    {
        if (_equipmentContainerIdentifier != null)
        {
            return _equipmentContainerIdentifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.5",
            Type = @"Field",
            Position = @"SAC.5",
            Name = @"Equipment Container Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the container in a particular device (e.g., one container in a carousel or rack of containers within an analyzer, analyzer specific bar code mapping, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.5.1",
                            Type = @"Component",
                            Position = @"SAC.5.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.5.2",
                            Type = @"Component",
                            Position = @"SAC.5.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.5.3",
                            Type = @"Component",
                            Position = @"SAC.5.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SAC.5.4",
                            Type = @"Component",
                            Position = @"SAC.5.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _equipmentContainerIdentifier = new HL7V251Field
        {
            field = message[@"SAC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_equipmentContainerIdentifier.field.FieldRepetitions != null && _equipmentContainerIdentifier.field.FieldRepetitions.Count > 0)
        {
            _equipmentContainerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_equipmentContainerIdentifier, fieldData);
        }

        return _equipmentContainerIdentifier;
    } 
}

internal HL7V251Field _specimenSource;

public HL7V251Field SpecimenSource
{
    get
    {
        if (_specimenSource != null)
        {
            return _specimenSource;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.6",
            Type = @"Field",
            Position = @"SAC.6",
            Name = @"Specimen Source",
            Length = 300,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"SPS",
            DataTypeName = @"Specimen Source",
            TableId = null,
            TableName = null,
            Description = @"This field is the site where the specimen should be obtained or where the service should be performed.

This field is deprecated and retained for backward compatibility.  This field is conditional, meaning that, in case where the SPM segment is used in a message together with the SAC, this field should be ignored. The reader is referred to the SPM Specimen segment in chapter 7. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.6.1",
                            Type = @"Component",
                            Position = @"SAC.6.1",
                            Name = @"Specimen Source Name Or Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"contains the specimen source name or code (as a CWE data type component). (Even in the case of observations whose name implies the source, a source may be required, e.g., blood culture-heart blood.)",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SAC.6.1.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.1",
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
                            Id = @"SAC.6.1.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.2",
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
                            Id = @"SAC.6.1.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.1.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.4",
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
                            Id = @"SAC.6.1.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.5",
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
                            Id = @"SAC.6.1.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.6",
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
                            Id = @"SAC.6.1.7",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.1.8",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.1.9",
                            Type = @"SubComponent",
                            Position = @"SAC.6.1.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.2",
                            Type = @"Component",
                            Position = @"SAC.6.2",
                            Name = @"Additives",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0371",
                            TableName = @"Additive/Preservative",
                            Description = @"identifies an additive introduced to the specimen before or at the time of collection. Refer to HL7 Table0371 - Additive in chapter 7 for valid values. The tables values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SAC.6.2.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.2.1",
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
                            Id = @"SAC.6.2.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.2.2",
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
                            Id = @"SAC.6.2.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.2.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.2.4",
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
                            Id = @"SAC.6.2.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.2.5",
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
                            Id = @"SAC.6.2.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.2.6",
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
                            Id = @"SAC.6.2.7",
                            Type = @"SubComponent",
                            Position = @"SAC.6.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.2.8",
                            Type = @"SubComponent",
                            Position = @"SAC.6.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.2.9",
                            Type = @"SubComponent",
                            Position = @"SAC.6.2.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.3",
                            Type = @"Component",
                            Position = @"SAC.6.3",
                            Name = @"Specimen Collection Method",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"describes the method of collection when that information is a part of the order. When the method of collection is logically an observation result, it should be included as a result segment (i.e., OBX segment).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.4",
                            Type = @"Component",
                            Position = @"SAC.6.4",
                            Name = @"Body Site",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0163",
                            TableName = @"Body site",
                            Description = @"This component specifies the body site from which the specimen was obtained. A nationally recognized coding system is to be used for this field. Valid coding sources for this field include:",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SAC.6.4.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.1",
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
                            Id = @"SAC.6.4.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.2",
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
                            Id = @"SAC.6.4.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.4.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.4",
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
                            Id = @"SAC.6.4.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.5",
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
                            Id = @"SAC.6.4.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.6",
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
                            Id = @"SAC.6.4.7",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.4.8",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.4.9",
                            Type = @"SubComponent",
                            Position = @"SAC.6.4.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.5",
                            Type = @"Component",
                            Position = @"SAC.6.5",
                            Name = @"Site Modifier",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0495",
                            TableName = @"Body Site Modifier",
                            Description = @"modifies body site. For example, the site could be antecubital fossa, and the site modifier right. Refer to HL7 Table 0495 Body Site Modifier for allowed values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SAC.6.5.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.1",
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
                            Id = @"SAC.6.5.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.2",
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
                            Id = @"SAC.6.5.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.5.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.4",
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
                            Id = @"SAC.6.5.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.5",
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
                            Id = @"SAC.6.5.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.6",
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
                            Id = @"SAC.6.5.7",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.5.8",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.5.9",
                            Type = @"SubComponent",
                            Position = @"SAC.6.5.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.6",
                            Type = @"Component",
                            Position = @"SAC.6.6",
                            Name = @"Collection Method Modifier Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"I ndicates whether the specimen is frozen as part of the collection method. Suggested values are F (Frozen); R (Refrigerated). If the component is blank, the specimen is assumed to be at room temperature.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SAC.6.6.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.1",
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
                            Id = @"SAC.6.6.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.2",
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
                            Id = @"SAC.6.6.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.6.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.4",
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
                            Id = @"SAC.6.6.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.5",
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
                            Id = @"SAC.6.6.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.6",
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
                            Id = @"SAC.6.6.7",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.6.8",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.6.9",
                            Type = @"SubComponent",
                            Position = @"SAC.6.6.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.7",
                            Type = @"Component",
                            Position = @"SAC.6.7",
                            Name = @"Specimen Role",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0369",
                            TableName = @"Specimen Role",
                            Description = @"indicates the role of the sample. Refer to User-defined Table 0369 - Specimen role for suggested values. Each of these values is normally identifiable by the systems and its components and can influence processing and data management related to the specimen.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SAC.6.7.1",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.1",
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
                            Id = @"SAC.6.7.2",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.2",
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
                            Id = @"SAC.6.7.3",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.7.4",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.4",
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
                            Id = @"SAC.6.7.5",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.5",
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
                            Id = @"SAC.6.7.6",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.6",
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
                            Id = @"SAC.6.7.7",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.7.8",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.6.7.9",
                            Type = @"SubComponent",
                            Position = @"SAC.6.7.9",
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
                        },}
                        },
                        }
        }

        _specimenSource = new HL7V251Field
        {
            field = message[@"SAC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenSource.field.FieldRepetitions != null && _specimenSource.field.FieldRepetitions.Count > 0)
        {
            _specimenSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_specimenSource, fieldData);
        }

        return _specimenSource;
    } 
}

internal HL7V251Field _registrationDateTime;

public HL7V251Field RegistrationDateTime
{
    get
    {
        if (_registrationDateTime != null)
        {
            return _registrationDateTime;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.7",
            Type = @"Field",
            Position = @"SAC.7",
            Name = @"Registration Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time that the container was last registered with the ""automated system."", e.g., reading of a container bar code by a device.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.7.1",
                            Type = @"Component",
                            Position = @"SAC.7.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.7.2",
                            Type = @"Component",
                            Position = @"SAC.7.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _registrationDateTime = new HL7V251Field
        {
            field = message[@"SAC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_registrationDateTime.field.FieldRepetitions != null && _registrationDateTime.field.FieldRepetitions.Count > 0)
        {
            _registrationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_registrationDateTime, fieldData);
        }

        return _registrationDateTime;
    } 
}

internal HL7V251Field _containerStatus;

public HL7V251Field ContainerStatus
{
    get
    {
        if (_containerStatus != null)
        {
            return _containerStatus;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.8",
            Type = @"Field",
            Position = @"SAC.8",
            Name = @"Container Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0370",
            TableName = @"Container status",
            Description = @"This field identifies the status of the unique container in which the specimen resides at the time that the transaction was initiated. Refer to HL7 Table 0370 - Container status for valid values. The equipment specific container status should be sent as <alternate identifier> as needed.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.8.1",
                            Type = @"Component",
                            Position = @"SAC.8.1",
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
                            Id = @"SAC.8.2",
                            Type = @"Component",
                            Position = @"SAC.8.2",
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
                            Id = @"SAC.8.3",
                            Type = @"Component",
                            Position = @"SAC.8.3",
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
                            Id = @"SAC.8.4",
                            Type = @"Component",
                            Position = @"SAC.8.4",
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
                            Id = @"SAC.8.5",
                            Type = @"Component",
                            Position = @"SAC.8.5",
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
                            Id = @"SAC.8.6",
                            Type = @"Component",
                            Position = @"SAC.8.6",
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
                        },
                        }
        }

        _containerStatus = new HL7V251Field
        {
            field = message[@"SAC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerStatus.field.FieldRepetitions != null && _containerStatus.field.FieldRepetitions.Count > 0)
        {
            _containerStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_containerStatus, fieldData);
        }

        return _containerStatus;
    } 
}

internal HL7V251Field _carrierType;

public HL7V251Field CarrierType
{
    get
    {
        if (_carrierType != null)
        {
            return _carrierType;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.9",
            Type = @"Field",
            Position = @"SAC.9",
            Name = @"Carrier Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0378",
            TableName = @"Carrier type",
            Description = @"This field identifies the type of the carrier. Refer to User-defined Table 0378 - Carrier type for suggested values. Because the geometry can be different, the carrier type should, if possible, express the number of positions in the carrier.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.9.1",
                            Type = @"Component",
                            Position = @"SAC.9.1",
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
                            Id = @"SAC.9.2",
                            Type = @"Component",
                            Position = @"SAC.9.2",
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
                            Id = @"SAC.9.3",
                            Type = @"Component",
                            Position = @"SAC.9.3",
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
                            Id = @"SAC.9.4",
                            Type = @"Component",
                            Position = @"SAC.9.4",
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
                            Id = @"SAC.9.5",
                            Type = @"Component",
                            Position = @"SAC.9.5",
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
                            Id = @"SAC.9.6",
                            Type = @"Component",
                            Position = @"SAC.9.6",
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
                        },
                        }
        }

        _carrierType = new HL7V251Field
        {
            field = message[@"SAC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_carrierType.field.FieldRepetitions != null && _carrierType.field.FieldRepetitions.Count > 0)
        {
            _carrierType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_carrierType, fieldData);
        }

        return _carrierType;
    } 
}

internal HL7V251Field _carrierIdentifier;

public HL7V251Field CarrierIdentifier
{
    get
    {
        if (_carrierIdentifier != null)
        {
            return _carrierIdentifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.10",
            Type = @"Field",
            Position = @"SAC.10",
            Name = @"Carrier Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the carrier. It is the ID (e.g., number or bar code) of the carrier where the container (e.g., tube) is located.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.10.1",
                            Type = @"Component",
                            Position = @"SAC.10.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.10.2",
                            Type = @"Component",
                            Position = @"SAC.10.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.10.3",
                            Type = @"Component",
                            Position = @"SAC.10.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SAC.10.4",
                            Type = @"Component",
                            Position = @"SAC.10.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _carrierIdentifier = new HL7V251Field
        {
            field = message[@"SAC"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_carrierIdentifier.field.FieldRepetitions != null && _carrierIdentifier.field.FieldRepetitions.Count > 0)
        {
            _carrierIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_carrierIdentifier, fieldData);
        }

        return _carrierIdentifier;
    } 
}

internal HL7V251Field _positioninCarrier;

public HL7V251Field PositioninCarrier
{
    get
    {
        if (_positioninCarrier != null)
        {
            return _positioninCarrier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.11",
            Type = @"Field",
            Position = @"SAC.11",
            Name = @"Position in Carrier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NA",
            DataTypeName = @"Numeric Array",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the position of the container in the carrier (e.g., 13). The sub-components allow, if necessary, to transfer multiple axis information, e.g., 2-dimensional carrier (X^Y).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.11.1",
                            Type = @"Component",
                            Position = @"SAC.11.1",
                            Name = @"Value1",
                            Length = 16,
                            Usage = @"R",
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
                            Id = @"SAC.11.2",
                            Type = @"Component",
                            Position = @"SAC.11.2",
                            Name = @"Value2",
                            Length = 16,
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
                            Id = @"SAC.11.3",
                            Type = @"Component",
                            Position = @"SAC.11.3",
                            Name = @"Value3",
                            Length = 16,
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
                            Id = @"SAC.11.4",
                            Type = @"Component",
                            Position = @"SAC.11.4",
                            Name = @"Value4",
                            Length = 16,
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
                            Id = @"SAC.11.5",
                            Type = @"Component",
                            Position = @"SAC.11.5",
                            Name = @"Value5",
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
                            Id = @"SAC.11.6",
                            Type = @"Component",
                            Position = @"SAC.11.6",
                            Name = @"Value6",
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
                            Id = @"SAC.11.7",
                            Type = @"Component",
                            Position = @"SAC.11.7",
                            Name = @"Value7",
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
                            Id = @"SAC.11.8",
                            Type = @"Component",
                            Position = @"SAC.11.8",
                            Name = @"Value8",
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
                            Id = @"SAC.11.9",
                            Type = @"Component",
                            Position = @"SAC.11.9",
                            Name = @"Value9",
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
                            Id = @"SAC.11.10",
                            Type = @"Component",
                            Position = @"SAC.11.10",
                            Name = @"Value10",
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
                        }
        }

        _positioninCarrier = new HL7V251Field
        {
            field = message[@"SAC"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_positioninCarrier.field.FieldRepetitions != null && _positioninCarrier.field.FieldRepetitions.Count > 0)
        {
            _positioninCarrier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_positioninCarrier, fieldData);
        }

        return _positioninCarrier;
    } 
}

internal HL7V251Field _trayTypeSAC;

public HL7V251Field TrayTypeSAC
{
    get
    {
        if (_trayTypeSAC != null)
        {
            return _trayTypeSAC;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.12",
            Type = @"Field",
            Position = @"SAC.12",
            Name = @"Tray Type - SAC",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0379",
            TableName = @"Tray type",
            Description = @"This field identifies the type of the tray. Refer to User-defined Table 0379 - Tray type for suggested values. Because the geometry can be different, the tray type should if possible express the number of positions in the tray.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.12.1",
                            Type = @"Component",
                            Position = @"SAC.12.1",
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
                            Id = @"SAC.12.2",
                            Type = @"Component",
                            Position = @"SAC.12.2",
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
                            Id = @"SAC.12.3",
                            Type = @"Component",
                            Position = @"SAC.12.3",
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
                            Id = @"SAC.12.4",
                            Type = @"Component",
                            Position = @"SAC.12.4",
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
                            Id = @"SAC.12.5",
                            Type = @"Component",
                            Position = @"SAC.12.5",
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
                            Id = @"SAC.12.6",
                            Type = @"Component",
                            Position = @"SAC.12.6",
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
                        },
                        }
        }

        _trayTypeSAC = new HL7V251Field
        {
            field = message[@"SAC"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_trayTypeSAC.field.FieldRepetitions != null && _trayTypeSAC.field.FieldRepetitions.Count > 0)
        {
            _trayTypeSAC.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_trayTypeSAC, fieldData);
        }

        return _trayTypeSAC;
    } 
}

internal HL7V251Field _trayIdentifier;

public HL7V251Field TrayIdentifier
{
    get
    {
        if (_trayIdentifier != null)
        {
            return _trayIdentifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.13",
            Type = @"Field",
            Position = @"SAC.13",
            Name = @"Tray Identifier",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the tray identifier (e.g., a number of a tray or a bar code on the tray), where the container carrier is located.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.13.1",
                            Type = @"Component",
                            Position = @"SAC.13.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.13.2",
                            Type = @"Component",
                            Position = @"SAC.13.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.13.3",
                            Type = @"Component",
                            Position = @"SAC.13.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SAC.13.4",
                            Type = @"Component",
                            Position = @"SAC.13.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _trayIdentifier = new HL7V251Field
        {
            field = message[@"SAC"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_trayIdentifier.field.FieldRepetitions != null && _trayIdentifier.field.FieldRepetitions.Count > 0)
        {
            _trayIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_trayIdentifier, fieldData);
        }

        return _trayIdentifier;
    } 
}

internal HL7V251Field _positioninTray;

public HL7V251Field PositioninTray
{
    get
    {
        if (_positioninTray != null)
        {
            return _positioninTray;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.14",
            Type = @"Field",
            Position = @"SAC.14",
            Name = @"Position in Tray",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NA",
            DataTypeName = @"Numeric Array",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the position of the carrier in the tray. The sub-components allow, if necessary, to transfer multiple axis information, e.g., 2-dimensional tray (X^Y).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.14.1",
                            Type = @"Component",
                            Position = @"SAC.14.1",
                            Name = @"Value1",
                            Length = 16,
                            Usage = @"R",
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
                            Id = @"SAC.14.2",
                            Type = @"Component",
                            Position = @"SAC.14.2",
                            Name = @"Value2",
                            Length = 16,
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
                            Id = @"SAC.14.3",
                            Type = @"Component",
                            Position = @"SAC.14.3",
                            Name = @"Value3",
                            Length = 16,
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
                            Id = @"SAC.14.4",
                            Type = @"Component",
                            Position = @"SAC.14.4",
                            Name = @"Value4",
                            Length = 16,
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
                            Id = @"SAC.14.5",
                            Type = @"Component",
                            Position = @"SAC.14.5",
                            Name = @"Value5",
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
                            Id = @"SAC.14.6",
                            Type = @"Component",
                            Position = @"SAC.14.6",
                            Name = @"Value6",
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
                            Id = @"SAC.14.7",
                            Type = @"Component",
                            Position = @"SAC.14.7",
                            Name = @"Value7",
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
                            Id = @"SAC.14.8",
                            Type = @"Component",
                            Position = @"SAC.14.8",
                            Name = @"Value8",
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
                            Id = @"SAC.14.9",
                            Type = @"Component",
                            Position = @"SAC.14.9",
                            Name = @"Value9",
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
                            Id = @"SAC.14.10",
                            Type = @"Component",
                            Position = @"SAC.14.10",
                            Name = @"Value10",
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
                        }
        }

        _positioninTray = new HL7V251Field
        {
            field = message[@"SAC"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_positioninTray.field.FieldRepetitions != null && _positioninTray.field.FieldRepetitions.Count > 0)
        {
            _positioninTray.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_positioninTray, fieldData);
        }

        return _positioninTray;
    } 
}

internal HL7V251Field _location;

public HL7V251Field Location
{
    get
    {
        if (_location != null)
        {
            return _location;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.15",
            Type = @"Field",
            Position = @"SAC.15",
            Name = @"Location",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the physical location that the specimen was at the time that the transaction was initiated. The location description can vary with the LAS. For example, it can be an X,Y,Z coordinate in a storage system; a refrigerator number and drawer number where the container-carrier-tray is located; or it can be the name of the institution and the laboratory which owns the container currently. The repeating of this field allows for hierarchical representation of location (lowest level first), e.g., shelf number, refrigerator storage id, lab name, institution name, etc.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.15.1",
                            Type = @"Component",
                            Position = @"SAC.15.1",
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
                            Id = @"SAC.15.2",
                            Type = @"Component",
                            Position = @"SAC.15.2",
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
                            Id = @"SAC.15.3",
                            Type = @"Component",
                            Position = @"SAC.15.3",
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
                            Id = @"SAC.15.4",
                            Type = @"Component",
                            Position = @"SAC.15.4",
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
                            Id = @"SAC.15.5",
                            Type = @"Component",
                            Position = @"SAC.15.5",
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
                            Id = @"SAC.15.6",
                            Type = @"Component",
                            Position = @"SAC.15.6",
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
                        },
                        }
        }

        _location = new HL7V251Field
        {
            field = message[@"SAC"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_location.field.FieldRepetitions != null && _location.field.FieldRepetitions.Count > 0)
        {
            _location.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_location, fieldData);
        }

        return _location;
    } 
}

internal HL7V251Field _containerHeight;

public HL7V251Field ContainerHeight
{
    get
    {
        if (_containerHeight != null)
        {
            return _containerHeight;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.16",
            Type = @"Field",
            Position = @"SAC.16",
            Name = @"Container Height",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the height of the container in units specified below.",
            Sample = @"",
            Fields = null
        }

        _containerHeight = new HL7V251Field
        {
            field = message[@"SAC"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerHeight.field.FieldRepetitions != null && _containerHeight.field.FieldRepetitions.Count > 0)
        {
            _containerHeight.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_containerHeight, fieldData);
        }

        return _containerHeight;
    } 
}

internal HL7V251Field _containerDiameter;

public HL7V251Field ContainerDiameter
{
    get
    {
        if (_containerDiameter != null)
        {
            return _containerDiameter;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.17",
            Type = @"Field",
            Position = @"SAC.17",
            Name = @"Container Diameter",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the outside diameter of the container in units specified below.",
            Sample = @"",
            Fields = null
        }

        _containerDiameter = new HL7V251Field
        {
            field = message[@"SAC"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerDiameter.field.FieldRepetitions != null && _containerDiameter.field.FieldRepetitions.Count > 0)
        {
            _containerDiameter.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_containerDiameter, fieldData);
        }

        return _containerDiameter;
    } 
}

internal HL7V251Field _barrierDelta;

public HL7V251Field BarrierDelta
{
    get
    {
        if (_barrierDelta != null)
        {
            return _barrierDelta;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.18",
            Type = @"Field",
            Position = @"SAC.18",
            Name = @"Barrier Delta",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the distance from the Point of Reference to the separator material (barrier) within the container in units specified below. This distance may be provided by the LAS to the instrument and/or specimen processing/handling device to facilitate the insertion of a sampling probe into the specimen without touching the separator.",
            Sample = @"",
            Fields = null
        }

        _barrierDelta = new HL7V251Field
        {
            field = message[@"SAC"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_barrierDelta.field.FieldRepetitions != null && _barrierDelta.field.FieldRepetitions.Count > 0)
        {
            _barrierDelta.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_barrierDelta, fieldData);
        }

        return _barrierDelta;
    } 
}

internal HL7V251Field _bottomDelta;

public HL7V251Field BottomDelta
{
    get
    {
        if (_bottomDelta != null)
        {
            return _bottomDelta;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.19",
            Type = @"Field",
            Position = @"SAC.19",
            Name = @"Bottom Delta",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the distance from the Point of Reference to the outside bottom of the container in units specified below",
            Sample = @"",
            Fields = null
        }

        _bottomDelta = new HL7V251Field
        {
            field = message[@"SAC"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bottomDelta.field.FieldRepetitions != null && _bottomDelta.field.FieldRepetitions.Count > 0)
        {
            _bottomDelta.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_bottomDelta, fieldData);
        }

        return _bottomDelta;
    } 
}

internal HL7V251Field _containerHeightDiameterDeltaUnits;

public HL7V251Field ContainerHeightDiameterDeltaUnits
{
    get
    {
        if (_containerHeightDiameterDeltaUnits != null)
        {
            return _containerHeightDiameterDeltaUnits;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.20",
            Type = @"Field",
            Position = @"SAC.20",
            Name = @"Container Height/Diameter/Delta Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit identifier that is being used to describe the diameter, height and deltas of the container. If the units are ISO+ units, they should be recorded as single case abbreviations. If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters. The default unit is millimeters (mm), which should be assumed if no units are reported.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.20.1",
                            Type = @"Component",
                            Position = @"SAC.20.1",
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
                            Id = @"SAC.20.2",
                            Type = @"Component",
                            Position = @"SAC.20.2",
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
                            Id = @"SAC.20.3",
                            Type = @"Component",
                            Position = @"SAC.20.3",
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
                            Id = @"SAC.20.4",
                            Type = @"Component",
                            Position = @"SAC.20.4",
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
                            Id = @"SAC.20.5",
                            Type = @"Component",
                            Position = @"SAC.20.5",
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
                            Id = @"SAC.20.6",
                            Type = @"Component",
                            Position = @"SAC.20.6",
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
                        },
                        }
        }

        _containerHeightDiameterDeltaUnits = new HL7V251Field
        {
            field = message[@"SAC"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerHeightDiameterDeltaUnits.field.FieldRepetitions != null && _containerHeightDiameterDeltaUnits.field.FieldRepetitions.Count > 0)
        {
            _containerHeightDiameterDeltaUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_containerHeightDiameterDeltaUnits, fieldData);
        }

        return _containerHeightDiameterDeltaUnits;
    } 
}

internal HL7V251Field _containerVolume;

public HL7V251Field ContainerVolume
{
    get
    {
        if (_containerVolume != null)
        {
            return _containerVolume;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.21",
            Type = @"Field",
            Position = @"SAC.21",
            Name = @"Container Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the capacity of the container in the units specified below.",
            Sample = @"",
            Fields = null
        }

        _containerVolume = new HL7V251Field
        {
            field = message[@"SAC"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerVolume.field.FieldRepetitions != null && _containerVolume.field.FieldRepetitions.Count > 0)
        {
            _containerVolume.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_containerVolume, fieldData);
        }

        return _containerVolume;
    } 
}

internal HL7V251Field _availableSpecimenVolume;

public HL7V251Field AvailableSpecimenVolume
{
    get
    {
        if (_availableSpecimenVolume != null)
        {
            return _availableSpecimenVolume;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.22",
            Type = @"Field",
            Position = @"SAC.22",
            Name = @"Available Specimen Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the current specimen volume available for use in this container in the units specified below.",
            Sample = @"",
            Fields = null
        }

        _availableSpecimenVolume = new HL7V251Field
        {
            field = message[@"SAC"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_availableSpecimenVolume.field.FieldRepetitions != null && _availableSpecimenVolume.field.FieldRepetitions.Count > 0)
        {
            _availableSpecimenVolume.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_availableSpecimenVolume, fieldData);
        }

        return _availableSpecimenVolume;
    } 
}

internal HL7V251Field _initialSpecimenVolume;

public HL7V251Field InitialSpecimenVolume
{
    get
    {
        if (_initialSpecimenVolume != null)
        {
            return _initialSpecimenVolume;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.23",
            Type = @"Field",
            Position = @"SAC.23",
            Name = @"Initial Specimen Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the volume of the specimen initially filled in this container in the units specified below.",
            Sample = @"",
            Fields = null
        }

        _initialSpecimenVolume = new HL7V251Field
        {
            field = message[@"SAC"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_initialSpecimenVolume.field.FieldRepetitions != null && _initialSpecimenVolume.field.FieldRepetitions.Count > 0)
        {
            _initialSpecimenVolume.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_initialSpecimenVolume, fieldData);
        }

        return _initialSpecimenVolume;
    } 
}

internal HL7V251Field _volumeUnits;

public HL7V251Field VolumeUnits
{
    get
    {
        if (_volumeUnits != null)
        {
            return _volumeUnits;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.24",
            Type = @"Field",
            Position = @"SAC.24",
            Name = @"Volume Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit identifier that is being used to describe the volume of the container. If the units are ISO+ units, they should be recorded as single case abbreviations. The default unit is milliliters (ml), which should be assumed if no units are reported.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.24.1",
                            Type = @"Component",
                            Position = @"SAC.24.1",
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
                            Id = @"SAC.24.2",
                            Type = @"Component",
                            Position = @"SAC.24.2",
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
                            Id = @"SAC.24.3",
                            Type = @"Component",
                            Position = @"SAC.24.3",
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
                            Id = @"SAC.24.4",
                            Type = @"Component",
                            Position = @"SAC.24.4",
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
                            Id = @"SAC.24.5",
                            Type = @"Component",
                            Position = @"SAC.24.5",
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
                            Id = @"SAC.24.6",
                            Type = @"Component",
                            Position = @"SAC.24.6",
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
                        },
                        }
        }

        _volumeUnits = new HL7V251Field
        {
            field = message[@"SAC"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_volumeUnits.field.FieldRepetitions != null && _volumeUnits.field.FieldRepetitions.Count > 0)
        {
            _volumeUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_volumeUnits, fieldData);
        }

        return _volumeUnits;
    } 
}

internal HL7V251Field _separatorType;

public HL7V251Field SeparatorType
{
    get
    {
        if (_separatorType != null)
        {
            return _separatorType;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.25",
            Type = @"Field",
            Position = @"SAC.25",
            Name = @"Separator Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0380",
            TableName = @"Separator type",
            Description = @"This field identifies the type of the separator that is being used (e.g., gel separator in the container - not to be confused with the communication separators). Refer to User-defined Table 0380 - Separator type for suggested values. It is recommended that the first table entry be ""NO"" meaning ""No Separator"".",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.25.1",
                            Type = @"Component",
                            Position = @"SAC.25.1",
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
                            Id = @"SAC.25.2",
                            Type = @"Component",
                            Position = @"SAC.25.2",
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
                            Id = @"SAC.25.3",
                            Type = @"Component",
                            Position = @"SAC.25.3",
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
                            Id = @"SAC.25.4",
                            Type = @"Component",
                            Position = @"SAC.25.4",
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
                            Id = @"SAC.25.5",
                            Type = @"Component",
                            Position = @"SAC.25.5",
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
                            Id = @"SAC.25.6",
                            Type = @"Component",
                            Position = @"SAC.25.6",
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
                        },
                        }
        }

        _separatorType = new HL7V251Field
        {
            field = message[@"SAC"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_separatorType.field.FieldRepetitions != null && _separatorType.field.FieldRepetitions.Count > 0)
        {
            _separatorType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_separatorType, fieldData);
        }

        return _separatorType;
    } 
}

internal HL7V251Field _capType;

public HL7V251Field CapType
{
    get
    {
        if (_capType != null)
        {
            return _capType;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.26",
            Type = @"Field",
            Position = @"SAC.26",
            Name = @"Cap Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0381",
            TableName = @"Cap type",
            Description = @"This field indicates the type of cap that is to be used with this container for decapping, piercing or other mechanisms. Refer to User-defined Table 0381 - Cap type for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.26.1",
                            Type = @"Component",
                            Position = @"SAC.26.1",
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
                            Id = @"SAC.26.2",
                            Type = @"Component",
                            Position = @"SAC.26.2",
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
                            Id = @"SAC.26.3",
                            Type = @"Component",
                            Position = @"SAC.26.3",
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
                            Id = @"SAC.26.4",
                            Type = @"Component",
                            Position = @"SAC.26.4",
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
                            Id = @"SAC.26.5",
                            Type = @"Component",
                            Position = @"SAC.26.5",
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
                            Id = @"SAC.26.6",
                            Type = @"Component",
                            Position = @"SAC.26.6",
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
                        },
                        }
        }

        _capType = new HL7V251Field
        {
            field = message[@"SAC"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_capType.field.FieldRepetitions != null && _capType.field.FieldRepetitions.Count > 0)
        {
            _capType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_capType, fieldData);
        }

        return _capType;
    } 
}

internal HL7V251Field _additive;

public HL7V251Field Additive
{
    get
    {
        if (_additive != null)
        {
            return _additive;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.27",
            Type = @"Field",
            Position = @"SAC.27",
            Name = @"Additive",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0371",
            TableName = @"Additive/Preservative",
            Description = @"This field identifies any additives introduced to the specimen before or at the time of collection. These additives may be introduced in order to preserve, maintain or enhance the particular nature or component of the specimen. It is a repetitive field. Refer to HL7 Table 0371 - Additive for valid values. 'The value set can be extended with user specific values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.27.1",
                            Type = @"Component",
                            Position = @"SAC.27.1",
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
                            Id = @"SAC.27.2",
                            Type = @"Component",
                            Position = @"SAC.27.2",
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
                            Id = @"SAC.27.3",
                            Type = @"Component",
                            Position = @"SAC.27.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.27.4",
                            Type = @"Component",
                            Position = @"SAC.27.4",
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
                            Id = @"SAC.27.5",
                            Type = @"Component",
                            Position = @"SAC.27.5",
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
                            Id = @"SAC.27.6",
                            Type = @"Component",
                            Position = @"SAC.27.6",
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
                            Id = @"SAC.27.7",
                            Type = @"Component",
                            Position = @"SAC.27.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.27.8",
                            Type = @"Component",
                            Position = @"SAC.27.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.27.9",
                            Type = @"Component",
                            Position = @"SAC.27.9",
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

        _additive = new HL7V251Field
        {
            field = message[@"SAC"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_additive.field.FieldRepetitions != null && _additive.field.FieldRepetitions.Count > 0)
        {
            _additive.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_additive, fieldData);
        }

        return _additive;
    } 
}

internal HL7V251Field _specimenComponent;

public HL7V251Field SpecimenComponent
{
    get
    {
        if (_specimenComponent != null)
        {
            return _specimenComponent;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.28",
            Type = @"Field",
            Position = @"SAC.28",
            Name = @"Specimen Component",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the specimen component, e.g., supernatant, sediment, etc. Refer to User-defined Table 0372 - Specimen component for valid values. This table's values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.28.1",
                            Type = @"Component",
                            Position = @"SAC.28.1",
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
                            Id = @"SAC.28.2",
                            Type = @"Component",
                            Position = @"SAC.28.2",
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
                            Id = @"SAC.28.3",
                            Type = @"Component",
                            Position = @"SAC.28.3",
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
                            Id = @"SAC.28.4",
                            Type = @"Component",
                            Position = @"SAC.28.4",
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
                            Id = @"SAC.28.5",
                            Type = @"Component",
                            Position = @"SAC.28.5",
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
                            Id = @"SAC.28.6",
                            Type = @"Component",
                            Position = @"SAC.28.6",
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
                        },
                        }
        }

        _specimenComponent = new HL7V251Field
        {
            field = message[@"SAC"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenComponent.field.FieldRepetitions != null && _specimenComponent.field.FieldRepetitions.Count > 0)
        {
            _specimenComponent.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_specimenComponent, fieldData);
        }

        return _specimenComponent;
    } 
}

internal HL7V251Field _dilutionFactor;

public HL7V251Field DilutionFactor
{
    get
    {
        if (_dilutionFactor != null)
        {
            return _dilutionFactor;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.29",
            Type = @"Field",
            Position = @"SAC.29",
            Name = @"Dilution Factor",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the factor of dilution already performed on the specimen. The equipment entity that changes the dilution is responsible for sending this information to other equipment. If the endogenous content of the test (analyte) in the diluent is required for the calculation of the test (analyte) concentration, then the test (analyte) specific values should be exchanged between the systems via Master Files or other means.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.29.1",
                            Type = @"Component",
                            Position = @"SAC.29.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.29.2",
                            Type = @"Component",
                            Position = @"SAC.29.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.29.3",
                            Type = @"Component",
                            Position = @"SAC.29.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.29.4",
                            Type = @"Component",
                            Position = @"SAC.29.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dilutionFactor = new HL7V251Field
        {
            field = message[@"SAC"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dilutionFactor.field.FieldRepetitions != null && _dilutionFactor.field.FieldRepetitions.Count > 0)
        {
            _dilutionFactor.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_dilutionFactor, fieldData);
        }

        return _dilutionFactor;
    } 
}

internal HL7V251Field _treatment;

public HL7V251Field Treatment
{
    get
    {
        if (_treatment != null)
        {
            return _treatment;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.30",
            Type = @"Field",
            Position = @"SAC.30",
            Name = @"Treatment",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0373",
            TableName = @"Treatment",
            Description = @"This field identifies the specimen treatment performed during lab processing. Refer to User-defined Table 0373 - Treatment for valid values. This table's values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.30.1",
                            Type = @"Component",
                            Position = @"SAC.30.1",
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
                            Id = @"SAC.30.2",
                            Type = @"Component",
                            Position = @"SAC.30.2",
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
                            Id = @"SAC.30.3",
                            Type = @"Component",
                            Position = @"SAC.30.3",
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
                            Id = @"SAC.30.4",
                            Type = @"Component",
                            Position = @"SAC.30.4",
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
                            Id = @"SAC.30.5",
                            Type = @"Component",
                            Position = @"SAC.30.5",
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
                            Id = @"SAC.30.6",
                            Type = @"Component",
                            Position = @"SAC.30.6",
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
                        },
                        }
        }

        _treatment = new HL7V251Field
        {
            field = message[@"SAC"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_treatment.field.FieldRepetitions != null && _treatment.field.FieldRepetitions.Count > 0)
        {
            _treatment.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_treatment, fieldData);
        }

        return _treatment;
    } 
}

internal HL7V251Field _temperature;

public HL7V251Field Temperature
{
    get
    {
        if (_temperature != null)
        {
            return _temperature;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.31",
            Type = @"Field",
            Position = @"SAC.31",
            Name = @"Temperature",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the specimen temperature in degrees Celsius [C] at the time of the transaction specified in the EQU segment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.31.1",
                            Type = @"Component",
                            Position = @"SAC.31.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.31.2",
                            Type = @"Component",
                            Position = @"SAC.31.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.31.3",
                            Type = @"Component",
                            Position = @"SAC.31.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.31.4",
                            Type = @"Component",
                            Position = @"SAC.31.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _temperature = new HL7V251Field
        {
            field = message[@"SAC"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_temperature.field.FieldRepetitions != null && _temperature.field.FieldRepetitions.Count > 0)
        {
            _temperature.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_temperature, fieldData);
        }

        return _temperature;
    } 
}

internal HL7V251Field _hemolysisIndex;

public HL7V251Field HemolysisIndex
{
    get
    {
        if (_hemolysisIndex != null)
        {
            return _hemolysisIndex;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.32",
            Type = @"Field",
            Position = @"SAC.32",
            Name = @"Hemolysis Index",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the index identifier that is being used to describe the Hemolysis Index of the specimen.",
            Sample = @"",
            Fields = null
        }

        _hemolysisIndex = new HL7V251Field
        {
            field = message[@"SAC"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hemolysisIndex.field.FieldRepetitions != null && _hemolysisIndex.field.FieldRepetitions.Count > 0)
        {
            _hemolysisIndex.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_hemolysisIndex, fieldData);
        }

        return _hemolysisIndex;
    } 
}

internal HL7V251Field _hemolysisIndexUnits;

public HL7V251Field HemolysisIndexUnits
{
    get
    {
        if (_hemolysisIndexUnits != null)
        {
            return _hemolysisIndexUnits;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.33",
            Type = @"Field",
            Position = @"SAC.33",
            Name = @"Hemolysis Index Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit's identifier that is being used to describe the Hemolysis Index of the specimen. It is recommended to use g/L. (The transmission of the index values is added here instead of the original use of the OBX segments, because the frequency of the transfer of the specimen details justifies use of more efficient mechanism.)",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.33.1",
                            Type = @"Component",
                            Position = @"SAC.33.1",
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
                            Id = @"SAC.33.2",
                            Type = @"Component",
                            Position = @"SAC.33.2",
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
                            Id = @"SAC.33.3",
                            Type = @"Component",
                            Position = @"SAC.33.3",
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
                            Id = @"SAC.33.4",
                            Type = @"Component",
                            Position = @"SAC.33.4",
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
                            Id = @"SAC.33.5",
                            Type = @"Component",
                            Position = @"SAC.33.5",
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
                            Id = @"SAC.33.6",
                            Type = @"Component",
                            Position = @"SAC.33.6",
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
                        },
                        }
        }

        _hemolysisIndexUnits = new HL7V251Field
        {
            field = message[@"SAC"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hemolysisIndexUnits.field.FieldRepetitions != null && _hemolysisIndexUnits.field.FieldRepetitions.Count > 0)
        {
            _hemolysisIndexUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_hemolysisIndexUnits, fieldData);
        }

        return _hemolysisIndexUnits;
    } 
}

internal HL7V251Field _lipemiaIndex;

public HL7V251Field LipemiaIndex
{
    get
    {
        if (_lipemiaIndex != null)
        {
            return _lipemiaIndex;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.34",
            Type = @"Field",
            Position = @"SAC.34",
            Name = @"Lipemia Index",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the index identifier that is being used to describe the Lipemia Index of the specimen. It is recommended to use the optical turbidity at 600 nm (in absorbance units).",
            Sample = @"",
            Fields = null
        }

        _lipemiaIndex = new HL7V251Field
        {
            field = message[@"SAC"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lipemiaIndex.field.FieldRepetitions != null && _lipemiaIndex.field.FieldRepetitions.Count > 0)
        {
            _lipemiaIndex.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_lipemiaIndex, fieldData);
        }

        return _lipemiaIndex;
    } 
}

internal HL7V251Field _lipemiaIndexUnits;

public HL7V251Field LipemiaIndexUnits
{
    get
    {
        if (_lipemiaIndexUnits != null)
        {
            return _lipemiaIndexUnits;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.35",
            Type = @"Field",
            Position = @"SAC.35",
            Name = @"Lipemia Index Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit's identifier that is being used to describe the Lipemia Index of the specimen.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.35.1",
                            Type = @"Component",
                            Position = @"SAC.35.1",
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
                            Id = @"SAC.35.2",
                            Type = @"Component",
                            Position = @"SAC.35.2",
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
                            Id = @"SAC.35.3",
                            Type = @"Component",
                            Position = @"SAC.35.3",
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
                            Id = @"SAC.35.4",
                            Type = @"Component",
                            Position = @"SAC.35.4",
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
                            Id = @"SAC.35.5",
                            Type = @"Component",
                            Position = @"SAC.35.5",
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
                            Id = @"SAC.35.6",
                            Type = @"Component",
                            Position = @"SAC.35.6",
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
                        },
                        }
        }

        _lipemiaIndexUnits = new HL7V251Field
        {
            field = message[@"SAC"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lipemiaIndexUnits.field.FieldRepetitions != null && _lipemiaIndexUnits.field.FieldRepetitions.Count > 0)
        {
            _lipemiaIndexUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_lipemiaIndexUnits, fieldData);
        }

        return _lipemiaIndexUnits;
    } 
}

internal HL7V251Field _icterusIndex;

public HL7V251Field IcterusIndex
{
    get
    {
        if (_icterusIndex != null)
        {
            return _icterusIndex;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.36",
            Type = @"Field",
            Position = @"SAC.36",
            Name = @"Icterus Index",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the index identifier that is being used to describe the Icterus Index of the specimen.",
            Sample = @"",
            Fields = null
        }

        _icterusIndex = new HL7V251Field
        {
            field = message[@"SAC"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_icterusIndex.field.FieldRepetitions != null && _icterusIndex.field.FieldRepetitions.Count > 0)
        {
            _icterusIndex.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_icterusIndex, fieldData);
        }

        return _icterusIndex;
    } 
}

internal HL7V251Field _icterusIndexUnits;

public HL7V251Field IcterusIndexUnits
{
    get
    {
        if (_icterusIndexUnits != null)
        {
            return _icterusIndexUnits;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.37",
            Type = @"Field",
            Position = @"SAC.37",
            Name = @"Icterus Index Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit's identifier that is being used to describe the Icterus Index of the specimen. It is recommended to use mMol/L of bilirubin.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.37.1",
                            Type = @"Component",
                            Position = @"SAC.37.1",
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
                            Id = @"SAC.37.2",
                            Type = @"Component",
                            Position = @"SAC.37.2",
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
                            Id = @"SAC.37.3",
                            Type = @"Component",
                            Position = @"SAC.37.3",
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
                            Id = @"SAC.37.4",
                            Type = @"Component",
                            Position = @"SAC.37.4",
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
                            Id = @"SAC.37.5",
                            Type = @"Component",
                            Position = @"SAC.37.5",
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
                            Id = @"SAC.37.6",
                            Type = @"Component",
                            Position = @"SAC.37.6",
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
                        },
                        }
        }

        _icterusIndexUnits = new HL7V251Field
        {
            field = message[@"SAC"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_icterusIndexUnits.field.FieldRepetitions != null && _icterusIndexUnits.field.FieldRepetitions.Count > 0)
        {
            _icterusIndexUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_icterusIndexUnits, fieldData);
        }

        return _icterusIndexUnits;
    } 
}

internal HL7V251Field _fibrinIndex;

public HL7V251Field FibrinIndex
{
    get
    {
        if (_fibrinIndex != null)
        {
            return _fibrinIndex;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.38",
            Type = @"Field",
            Position = @"SAC.38",
            Name = @"Fibrin Index",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the index identifier that is being used to describe the Fibrin Index of the specimen. In the case of only differentiating between Absent and Present, we recommend using 0 and 1 respectively and send the field Fibrin Index Units null.",
            Sample = @"",
            Fields = null
        }

        _fibrinIndex = new HL7V251Field
        {
            field = message[@"SAC"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fibrinIndex.field.FieldRepetitions != null && _fibrinIndex.field.FieldRepetitions.Count > 0)
        {
            _fibrinIndex.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fibrinIndex, fieldData);
        }

        return _fibrinIndex;
    } 
}

internal HL7V251Field _fibrinIndexUnits;

public HL7V251Field FibrinIndexUnits
{
    get
    {
        if (_fibrinIndexUnits != null)
        {
            return _fibrinIndexUnits;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.39",
            Type = @"Field",
            Position = @"SAC.39",
            Name = @"Fibrin Index Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unit's identifier that is being used to describe the Fibrin Index of the specimen.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.39.1",
                            Type = @"Component",
                            Position = @"SAC.39.1",
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
                            Id = @"SAC.39.2",
                            Type = @"Component",
                            Position = @"SAC.39.2",
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
                            Id = @"SAC.39.3",
                            Type = @"Component",
                            Position = @"SAC.39.3",
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
                            Id = @"SAC.39.4",
                            Type = @"Component",
                            Position = @"SAC.39.4",
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
                            Id = @"SAC.39.5",
                            Type = @"Component",
                            Position = @"SAC.39.5",
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
                            Id = @"SAC.39.6",
                            Type = @"Component",
                            Position = @"SAC.39.6",
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
                        },
                        }
        }

        _fibrinIndexUnits = new HL7V251Field
        {
            field = message[@"SAC"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fibrinIndexUnits.field.FieldRepetitions != null && _fibrinIndexUnits.field.FieldRepetitions.Count > 0)
        {
            _fibrinIndexUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_fibrinIndexUnits, fieldData);
        }

        return _fibrinIndexUnits;
    } 
}

internal HL7V251Field _systemInducedContaminants;

public HL7V251Field SystemInducedContaminants
{
    get
    {
        if (_systemInducedContaminants != null)
        {
            return _systemInducedContaminants;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.40",
            Type = @"Field",
            Position = @"SAC.40",
            Name = @"System Induced Contaminants",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0374",
            TableName = @"System induced contaminants",
            Description = @"This field describes the specimen contaminant identifier that is associated with the specimen in this container. Refer to User-defined Table 0374 - System induced contaminants for valid values. This table's values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.40.1",
                            Type = @"Component",
                            Position = @"SAC.40.1",
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
                            Id = @"SAC.40.2",
                            Type = @"Component",
                            Position = @"SAC.40.2",
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
                            Id = @"SAC.40.3",
                            Type = @"Component",
                            Position = @"SAC.40.3",
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
                            Id = @"SAC.40.4",
                            Type = @"Component",
                            Position = @"SAC.40.4",
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
                            Id = @"SAC.40.5",
                            Type = @"Component",
                            Position = @"SAC.40.5",
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
                            Id = @"SAC.40.6",
                            Type = @"Component",
                            Position = @"SAC.40.6",
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
                        },
                        }
        }

        _systemInducedContaminants = new HL7V251Field
        {
            field = message[@"SAC"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_systemInducedContaminants.field.FieldRepetitions != null && _systemInducedContaminants.field.FieldRepetitions.Count > 0)
        {
            _systemInducedContaminants.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_systemInducedContaminants, fieldData);
        }

        return _systemInducedContaminants;
    } 
}

internal HL7V251Field _drugInterference;

public HL7V251Field DrugInterference
{
    get
    {
        if (_drugInterference != null)
        {
            return _drugInterference;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.41",
            Type = @"Field",
            Position = @"SAC.41",
            Name = @"Drug Interference",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0382",
            TableName = @"Drug interference",
            Description = @"This field describes the drug interference identifier that is associated with the specimen. Refer to User-defined Table 0382 - Drug interference for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.41.1",
                            Type = @"Component",
                            Position = @"SAC.41.1",
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
                            Id = @"SAC.41.2",
                            Type = @"Component",
                            Position = @"SAC.41.2",
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
                            Id = @"SAC.41.3",
                            Type = @"Component",
                            Position = @"SAC.41.3",
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
                            Id = @"SAC.41.4",
                            Type = @"Component",
                            Position = @"SAC.41.4",
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
                            Id = @"SAC.41.5",
                            Type = @"Component",
                            Position = @"SAC.41.5",
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
                            Id = @"SAC.41.6",
                            Type = @"Component",
                            Position = @"SAC.41.6",
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
                        },
                        }
        }

        _drugInterference = new HL7V251Field
        {
            field = message[@"SAC"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_drugInterference.field.FieldRepetitions != null && _drugInterference.field.FieldRepetitions.Count > 0)
        {
            _drugInterference.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_drugInterference, fieldData);
        }

        return _drugInterference;
    } 
}

internal HL7V251Field _artificialBlood;

public HL7V251Field ArtificialBlood
{
    get
    {
        if (_artificialBlood != null)
        {
            return _artificialBlood;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.42",
            Type = @"Field",
            Position = @"SAC.42",
            Name = @"Artificial Blood",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0375",
            TableName = @"Artificial blood",
            Description = @"This field describes the artificial blood identifier that is associated with the specimen. Refer to User-defined Table 0375 - Artificial blood for valid values. This table's values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.42.1",
                            Type = @"Component",
                            Position = @"SAC.42.1",
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
                            Id = @"SAC.42.2",
                            Type = @"Component",
                            Position = @"SAC.42.2",
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
                            Id = @"SAC.42.3",
                            Type = @"Component",
                            Position = @"SAC.42.3",
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
                            Id = @"SAC.42.4",
                            Type = @"Component",
                            Position = @"SAC.42.4",
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
                            Id = @"SAC.42.5",
                            Type = @"Component",
                            Position = @"SAC.42.5",
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
                            Id = @"SAC.42.6",
                            Type = @"Component",
                            Position = @"SAC.42.6",
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
                        },
                        }
        }

        _artificialBlood = new HL7V251Field
        {
            field = message[@"SAC"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_artificialBlood.field.FieldRepetitions != null && _artificialBlood.field.FieldRepetitions.Count > 0)
        {
            _artificialBlood.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_artificialBlood, fieldData);
        }

        return _artificialBlood;
    } 
}

internal HL7V251Field _specialHandlingCode;

public HL7V251Field SpecialHandlingCode
{
    get
    {
        if (_specialHandlingCode != null)
        {
            return _specialHandlingCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.43",
            Type = @"Field",
            Position = @"SAC.43",
            Name = @"Special Handling Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0376",
            TableName = @"Special Handling Code",
            Description = @"This field describes any special handling considerations that are associated with the specimen in the specific container (e.g. centrifugation). This describes how the specimen needs to be stored during collection, in transit, and upon receipt. Refer to User-defined Table 0376 - Special handling code for valid values. 'The value set can be extended with user specific values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.43.1",
                            Type = @"Component",
                            Position = @"SAC.43.1",
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
                            Id = @"SAC.43.2",
                            Type = @"Component",
                            Position = @"SAC.43.2",
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
                            Id = @"SAC.43.3",
                            Type = @"Component",
                            Position = @"SAC.43.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.43.4",
                            Type = @"Component",
                            Position = @"SAC.43.4",
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
                            Id = @"SAC.43.5",
                            Type = @"Component",
                            Position = @"SAC.43.5",
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
                            Id = @"SAC.43.6",
                            Type = @"Component",
                            Position = @"SAC.43.6",
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
                            Id = @"SAC.43.7",
                            Type = @"Component",
                            Position = @"SAC.43.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.43.8",
                            Type = @"Component",
                            Position = @"SAC.43.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SAC.43.9",
                            Type = @"Component",
                            Position = @"SAC.43.9",
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

        _specialHandlingCode = new HL7V251Field
        {
            field = message[@"SAC"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialHandlingCode.field.FieldRepetitions != null && _specialHandlingCode.field.FieldRepetitions.Count > 0)
        {
            _specialHandlingCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_specialHandlingCode, fieldData);
        }

        return _specialHandlingCode;
    } 
}

internal HL7V251Field _otherEnvironmentalFactors;

public HL7V251Field OtherEnvironmentalFactors
{
    get
    {
        if (_otherEnvironmentalFactors != null)
        {
            return _otherEnvironmentalFactors;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"SAC.44",
            Type = @"Field",
            Position = @"SAC.44",
            Name = @"Other Environmental Factors",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0377",
            TableName = @"Other environmental factors",
            Description = @"This field describes other environmental factors that are associated with the specimen in a specific container, e.g., atmospheric exposure. Refer to User-defined Table 0377 - Other environmental factors for valid values. This table's values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SAC.44.1",
                            Type = @"Component",
                            Position = @"SAC.44.1",
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
                            Id = @"SAC.44.2",
                            Type = @"Component",
                            Position = @"SAC.44.2",
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
                            Id = @"SAC.44.3",
                            Type = @"Component",
                            Position = @"SAC.44.3",
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
                            Id = @"SAC.44.4",
                            Type = @"Component",
                            Position = @"SAC.44.4",
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
                            Id = @"SAC.44.5",
                            Type = @"Component",
                            Position = @"SAC.44.5",
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
                            Id = @"SAC.44.6",
                            Type = @"Component",
                            Position = @"SAC.44.6",
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
                        },
                        }
        }

        _otherEnvironmentalFactors = new HL7V251Field
        {
            field = message[@"SAC"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_otherEnvironmentalFactors.field.FieldRepetitions != null && _otherEnvironmentalFactors.field.FieldRepetitions.Count > 0)
        {
            _otherEnvironmentalFactors.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_otherEnvironmentalFactors, fieldData);
        }

        return _otherEnvironmentalFactors;
    } 
}
    }
}
