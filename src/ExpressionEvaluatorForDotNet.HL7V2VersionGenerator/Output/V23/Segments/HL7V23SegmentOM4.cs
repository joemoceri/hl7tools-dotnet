using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentOM4
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM4"; } }

        public string SegmentId { get { return @"OM4"; } }
        
        public string LongName { get { return @"Observations that require specimens"; } }
        
        public string Description { get { return @"This segment applies to observations/batteries that require a specimen for their performance.  When an observation or battery requires multiple specimens for their performance (e.g., creatinine clearance requires a 24-hour urine specimen and a serum specimen), multiple segments may be included, one for each specimen type."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V23SegmentOM4(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _sequenceNumber;

public HL7V23Field SequenceNumber
{
    get
    {
        if (_sequenceNumber != null)
        {
            return _sequenceNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.1",
            Type = @"Field",
            Position = @"OM4.1",
            Name = @"Sequence Number",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the same value as the sequence number of the associated OM1 segment",
            Sample = @"",
            Fields = null
        }

        _sequenceNumber = new HL7V23Field
        {
            field = message[@"OM4"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumber.field.FieldRepetitions != null && _sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_sequenceNumber, fieldData);
        }

        return _sequenceNumber;
    } 
}

internal HL7V23Field _derivedSpecimen;

public HL7V23Field DerivedSpecimen
{
    get
    {
        if (_derivedSpecimen != null)
        {
            return _derivedSpecimen;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.2",
            Type = @"Field",
            Position = @"OM4.2",
            Name = @"Derived Specimen",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0170",
            TableName = @"Derived specimen",
            Description = @" This field contains the codes that identify the parents and children for diagnostic studies -- especially in microbiology -- where the initial specimen (e.g., blood) is processed to produce results (e.g., the identity of the bacteria grown out of the culture).  The process also produces new “specimens” (e.g., pure culture of staphylococcus, and E. Coli), and these are studied by a second order process (bacterial sensitivities). The parents (e.g., blood culture) and children (e.g., penicillin MIC) are identified in such cases.",
            Sample = @"",
            Fields = null
        }

        _derivedSpecimen = new HL7V23Field
        {
            field = message[@"OM4"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_derivedSpecimen.field.FieldRepetitions != null && _derivedSpecimen.field.FieldRepetitions.Count > 0)
        {
            _derivedSpecimen.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_derivedSpecimen, fieldData);
        }

        return _derivedSpecimen;
    } 
}

internal HL7V23Field _containerDescription;

public HL7V23Field ContainerDescription
{
    get
    {
        if (_containerDescription != null)
        {
            return _containerDescription;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.3",
            Type = @"Field",
            Position = @"OM4.3",
            Name = @"Container Description",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the physical appearance, including color of tube tops, shape, and material composition (e.g., red-top glass tube).  Note that the color is not necessarily a unique identifier of the additive and/or use of the tube.  This is especially true for black and some blue tube tops, as can be seen above.  Color is included here for user convenience",
            Sample = @"",
            Fields = null
        }

        _containerDescription = new HL7V23Field
        {
            field = message[@"OM4"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerDescription.field.FieldRepetitions != null && _containerDescription.field.FieldRepetitions.Count > 0)
        {
            _containerDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_containerDescription, fieldData);
        }

        return _containerDescription;
    } 
}

internal HL7V23Field _containerVolume;

public HL7V23Field ContainerVolume
{
    get
    {
        if (_containerVolume != null)
        {
            return _containerVolume;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.4",
            Type = @"Field",
            Position = @"OM4.4",
            Name = @"Container Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the capacity of the container",
            Sample = @"",
            Fields = null
        }

        _containerVolume = new HL7V23Field
        {
            field = message[@"OM4"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerVolume.field.FieldRepetitions != null && _containerVolume.field.FieldRepetitions.Count > 0)
        {
            _containerVolume.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_containerVolume, fieldData);
        }

        return _containerVolume;
    } 
}

internal HL7V23Field _containerUnits;

public HL7V23Field ContainerUnits
{
    get
    {
        if (_containerUnits != null)
        {
            return _containerUnits;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.5",
            Type = @"Field",
            Position = @"OM4.5",
            Name = @"Container Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the units of measure of the container volume.  If the units are ISO+ units, they should be recorded as single case abbreviations.  If the units are ANS+ or L (local), the units and the source code table must be recorded, except that in this case, component delimiters should be replaced by subcomponent delimiters.  For example, 1 indicates liters, whereas pt&&ANS+ indicates pints (ANSI units).  The default unit is milliliters (ml), which should be assumed if no units are reported",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM4.5.1",
                            Type = @"Component",
                            Position = @"OM4.5.1",
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
                            Id = @"OM4.5.2",
                            Type = @"Component",
                            Position = @"OM4.5.2",
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
                            Id = @"OM4.5.3",
                            Type = @"Component",
                            Position = @"OM4.5.3",
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
                            Id = @"OM4.5.4",
                            Type = @"Component",
                            Position = @"OM4.5.4",
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
                            Id = @"OM4.5.5",
                            Type = @"Component",
                            Position = @"OM4.5.5",
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
                            Id = @"OM4.5.6",
                            Type = @"Component",
                            Position = @"OM4.5.6",
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
                        }
        }

        _containerUnits = new HL7V23Field
        {
            field = message[@"OM4"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerUnits.field.FieldRepetitions != null && _containerUnits.field.FieldRepetitions.Count > 0)
        {
            _containerUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_containerUnits, fieldData);
        }

        return _containerUnits;
    } 
}

internal HL7V23Field _specimen;

public HL7V23Field Specimen
{
    get
    {
        if (_specimen != null)
        {
            return _specimen;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.6",
            Type = @"Field",
            Position = @"OM4.6",
            Name = @"Specimen",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field reports the specimen as one of the specimen codes described in ASTM Table 14 of 1238-91.  If multiple kinds of specimen are associated with this observation (as in the case for a creatinine clearance), separate them with repeat delimiters",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM4.6.1",
                            Type = @"Component",
                            Position = @"OM4.6.1",
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
                            Id = @"OM4.6.2",
                            Type = @"Component",
                            Position = @"OM4.6.2",
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
                            Id = @"OM4.6.3",
                            Type = @"Component",
                            Position = @"OM4.6.3",
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
                            Id = @"OM4.6.4",
                            Type = @"Component",
                            Position = @"OM4.6.4",
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
                            Id = @"OM4.6.5",
                            Type = @"Component",
                            Position = @"OM4.6.5",
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
                            Id = @"OM4.6.6",
                            Type = @"Component",
                            Position = @"OM4.6.6",
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
                        }
        }

        _specimen = new HL7V23Field
        {
            field = message[@"OM4"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimen.field.FieldRepetitions != null && _specimen.field.FieldRepetitions.Count > 0)
        {
            _specimen.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specimen, fieldData);
        }

        return _specimen;
    } 
}

internal HL7V23Field _additive;

public HL7V23Field Additive
{
    get
    {
        if (_additive != null)
        {
            return _additive;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.7",
            Type = @"Field",
            Position = @"OM4.7",
            Name = @"Additive",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the codes that should be those provided by NCCLS2.  The following list is not exhaustive; it includes only examples",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM4.7.1",
                            Type = @"Component",
                            Position = @"OM4.7.1",
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
                            Id = @"OM4.7.2",
                            Type = @"Component",
                            Position = @"OM4.7.2",
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
                            Id = @"OM4.7.3",
                            Type = @"Component",
                            Position = @"OM4.7.3",
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
                            Id = @"OM4.7.4",
                            Type = @"Component",
                            Position = @"OM4.7.4",
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
                            Id = @"OM4.7.5",
                            Type = @"Component",
                            Position = @"OM4.7.5",
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
                            Id = @"OM4.7.6",
                            Type = @"Component",
                            Position = @"OM4.7.6",
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
                        }
        }

        _additive = new HL7V23Field
        {
            field = message[@"OM4"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_additive.field.FieldRepetitions != null && _additive.field.FieldRepetitions.Count > 0)
        {
            _additive.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_additive, fieldData);
        }

        return _additive;
    } 
}

internal HL7V23Field _preparation;

public HL7V23Field Preparation
{
    get
    {
        if (_preparation != null)
        {
            return _preparation;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.8",
            Type = @"Field",
            Position = @"OM4.8",
            Name = @"Preparation",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the special processing that should be applied to the container, e.g., add acidifying tablets before sending",
            Sample = @"",
            Fields = null
        }

        _preparation = new HL7V23Field
        {
            field = message[@"OM4"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preparation.field.FieldRepetitions != null && _preparation.field.FieldRepetitions.Count > 0)
        {
            _preparation.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_preparation, fieldData);
        }

        return _preparation;
    } 
}

internal HL7V23Field _specialHandlingRequirements;

public HL7V23Field SpecialHandlingRequirements
{
    get
    {
        if (_specialHandlingRequirements != null)
        {
            return _specialHandlingRequirements;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.9",
            Type = @"Field",
            Position = @"OM4.9",
            Name = @"Special Handling Requirements",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the special handling requirements here (e.g., ice specimen, deliver within two hours of obtaining)",
            Sample = @"",
            Fields = null
        }

        _specialHandlingRequirements = new HL7V23Field
        {
            field = message[@"OM4"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialHandlingRequirements.field.FieldRepetitions != null && _specialHandlingRequirements.field.FieldRepetitions.Count > 0)
        {
            _specialHandlingRequirements.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specialHandlingRequirements, fieldData);
        }

        return _specialHandlingRequirements;
    } 
}

internal HL7V23Field _normalCollectionVolume;

public HL7V23Field NormalCollectionVolume
{
    get
    {
        if (_normalCollectionVolume != null)
        {
            return _normalCollectionVolume;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.10",
            Type = @"Field",
            Position = @"OM4.10",
            Name = @"Normal Collection Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the normal specimen volume required by the lab.  This is the amount used by the normal methods and provides enough specimens to repeat the procedure at least once if needed.  The default unit is milliliters (ml). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM4.10.1",
                            Type = @"Component",
                            Position = @"OM4.10.1",
                            Name = @"Quantity",
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
                            Id = @"OM4.10.2",
                            Type = @"Component",
                            Position = @"OM4.10.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _normalCollectionVolume = new HL7V23Field
        {
            field = message[@"OM4"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_normalCollectionVolume.field.FieldRepetitions != null && _normalCollectionVolume.field.FieldRepetitions.Count > 0)
        {
            _normalCollectionVolume.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_normalCollectionVolume, fieldData);
        }

        return _normalCollectionVolume;
    } 
}

internal HL7V23Field _minimumCollectionVolume;

public HL7V23Field MinimumCollectionVolume
{
    get
    {
        if (_minimumCollectionVolume != null)
        {
            return _minimumCollectionVolume;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.11",
            Type = @"Field",
            Position = @"OM4.11",
            Name = @"Minimum Collection Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount of specimen needed by the most specimen sparing method (e.g., using micro techniques).  The minimum amount allows for only one determination.  The default unit is milliliters (ml). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM4.11.1",
                            Type = @"Component",
                            Position = @"OM4.11.1",
                            Name = @"Quantity",
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
                            Id = @"OM4.11.2",
                            Type = @"Component",
                            Position = @"OM4.11.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _minimumCollectionVolume = new HL7V23Field
        {
            field = message[@"OM4"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_minimumCollectionVolume.field.FieldRepetitions != null && _minimumCollectionVolume.field.FieldRepetitions.Count > 0)
        {
            _minimumCollectionVolume.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_minimumCollectionVolume, fieldData);
        }

        return _minimumCollectionVolume;
    } 
}

internal HL7V23Field _specimenRequirements;

public HL7V23Field SpecimenRequirements
{
    get
    {
        if (_specimenRequirements != null)
        {
            return _specimenRequirements;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.12",
            Type = @"Field",
            Position = @"OM4.12",
            Name = @"Specimen Requirements",
            Length = 10240,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the other requirements for specimen delivery and special handling (e.g., delivery within one hour, iced). ",
            Sample = @"",
            Fields = null
        }

        _specimenRequirements = new HL7V23Field
        {
            field = message[@"OM4"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenRequirements.field.FieldRepetitions != null && _specimenRequirements.field.FieldRepetitions.Count > 0)
        {
            _specimenRequirements.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specimenRequirements, fieldData);
        }

        return _specimenRequirements;
    } 
}

internal HL7V23Field _specimenPriorities;

public HL7V23Field SpecimenPriorities
{
    get
    {
        if (_specimenPriorities != null)
        {
            return _specimenPriorities;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.13",
            Type = @"Field",
            Position = @"OM4.13",
            Name = @"Specimen Priorities",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0027",
            TableName = @"Priority",
            Description = @" This field contains the allowed priorities for obtaining the specimen.  Note that they may be different from the processing priorities given in OM1-25-processing priority.  When a test is requested, the specimen priority given in OBR-27-quantity/timing should be one of the priorities listed here.  Multiple priorities are separated by repeat delimiters.  Refer to HL7 table 0027 - Priority for valid values.",
            Sample = @"",
            Fields = null
        }

        _specimenPriorities = new HL7V23Field
        {
            field = message[@"OM4"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenPriorities.field.FieldRepetitions != null && _specimenPriorities.field.FieldRepetitions.Count > 0)
        {
            _specimenPriorities.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specimenPriorities, fieldData);
        }

        return _specimenPriorities;
    } 
}

internal HL7V23Field _specimenRetentionTime;

public HL7V23Field SpecimenRetentionTime
{
    get
    {
        if (_specimenRetentionTime != null)
        {
            return _specimenRetentionTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM4.14",
            Type = @"Field",
            Position = @"OM4.14",
            Name = @"Specimen Retention Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the usual time that a specimen for this observation is retained after the observation is completed, for the purpose of additional testing.  The first component is the duration, and the second component is an ISO time unit. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM4.14.1",
                            Type = @"Component",
                            Position = @"OM4.14.1",
                            Name = @"Quantity",
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
                            Id = @"OM4.14.2",
                            Type = @"Component",
                            Position = @"OM4.14.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _specimenRetentionTime = new HL7V23Field
        {
            field = message[@"OM4"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenRetentionTime.field.FieldRepetitions != null && _specimenRetentionTime.field.FieldRepetitions.Count > 0)
        {
            _specimenRetentionTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specimenRetentionTime, fieldData);
        }

        return _specimenRetentionTime;
    } 
}
    }
}
