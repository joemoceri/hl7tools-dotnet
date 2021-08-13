using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentSID
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SID"; } }

        public string SegmentId { get { return @"SID"; } }
        
        public string LongName { get { return @"Substance Identifier"; } }
        
        public string Description { get { return @"The Substance Identifier segment contains data necessary to identify the substance (e.g., reagents) used in the production of analytical test results. The combination of these fields must uniquely identify the substance, i.e., depending on the manufacturer all or some fields are required (this is the reason the optionality is 'C' (conditional)). If the analysis requires multiple substances, this segment is repeated for each substance. The segment(s) should be attached to the TCD segment."; } }
        
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

        public HL7V26SegmentSID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _applicationMethodIdentifier;

public HL7V26Field ApplicationMethodIdentifier
{
    get
    {
        if (_applicationMethodIdentifier != null)
        {
            return _applicationMethodIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SID.1",
            Type = @"Field",
            Position = @"SID.1",
            Name = @"Application / Method Identifier",
            Length = 705,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the application/method used for the analysis.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SID.1.1",
                            Type = @"Component",
                            Position = @"SID.1.1",
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
                            Id = @"SID.1.2",
                            Type = @"Component",
                            Position = @"SID.1.2",
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
                            Id = @"SID.1.3",
                            Type = @"Component",
                            Position = @"SID.1.3",
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
                            Id = @"SID.1.4",
                            Type = @"Component",
                            Position = @"SID.1.4",
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
                            Id = @"SID.1.5",
                            Type = @"Component",
                            Position = @"SID.1.5",
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
                            Id = @"SID.1.6",
                            Type = @"Component",
                            Position = @"SID.1.6",
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
                            Id = @"SID.1.7",
                            Type = @"Component",
                            Position = @"SID.1.7",
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
                            Id = @"SID.1.8",
                            Type = @"Component",
                            Position = @"SID.1.8",
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
                            Id = @"SID.1.9",
                            Type = @"Component",
                            Position = @"SID.1.9",
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

        _applicationMethodIdentifier = new HL7V26Field
        {
            field = message[@"SID"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationMethodIdentifier.field.FieldRepetitions != null && _applicationMethodIdentifier.field.FieldRepetitions.Count > 0)
        {
            _applicationMethodIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_applicationMethodIdentifier, fieldData);
        }

        return _applicationMethodIdentifier;
    } 
}

internal HL7V26Field _substanceLotNumber;

public HL7V26Field SubstanceLotNumber
{
    get
    {
        if (_substanceLotNumber != null)
        {
            return _substanceLotNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SID.2",
            Type = @"Field",
            Position = @"SID.2",
            Name = @"Substance Lot Number",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the lot number assigned by the manufacturer during production of the substance.",
            Sample = @"",
            Fields = null
        }

        _substanceLotNumber = new HL7V26Field
        {
            field = message[@"SID"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceLotNumber.field.FieldRepetitions != null && _substanceLotNumber.field.FieldRepetitions.Count > 0)
        {
            _substanceLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_substanceLotNumber, fieldData);
        }

        return _substanceLotNumber;
    } 
}

internal HL7V26Field _substanceContainerIdentifier;

public HL7V26Field SubstanceContainerIdentifier
{
    get
    {
        if (_substanceContainerIdentifier != null)
        {
            return _substanceContainerIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SID.3",
            Type = @"Field",
            Position = @"SID.3",
            Name = @"Substance Container Identifier",
            Length = 200,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the container assigned by the manufacturer during production of the substance. This identifier should be unique within specific lot of specific application / method.",
            Sample = @"",
            Fields = null
        }

        _substanceContainerIdentifier = new HL7V26Field
        {
            field = message[@"SID"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceContainerIdentifier.field.FieldRepetitions != null && _substanceContainerIdentifier.field.FieldRepetitions.Count > 0)
        {
            _substanceContainerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_substanceContainerIdentifier, fieldData);
        }

        return _substanceContainerIdentifier;
    } 
}

internal HL7V26Field _substanceManufacturerIdentifier;

public HL7V26Field SubstanceManufacturerIdentifier
{
    get
    {
        if (_substanceManufacturerIdentifier != null)
        {
            return _substanceManufacturerIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SID.4",
            Type = @"Field",
            Position = @"SID.4",
            Name = @"Substance Manufacturer Identifier",
            Length = 705,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0385",
            TableName = @"Manufacturer identifier",
            Description = @"This field identifies the manufacturer of this substance. Refer to User-defined Table 0385 - Manufacturer identifier for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SID.4.1",
                            Type = @"Component",
                            Position = @"SID.4.1",
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
                            Id = @"SID.4.2",
                            Type = @"Component",
                            Position = @"SID.4.2",
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
                            Id = @"SID.4.3",
                            Type = @"Component",
                            Position = @"SID.4.3",
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
                            Id = @"SID.4.4",
                            Type = @"Component",
                            Position = @"SID.4.4",
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
                            Id = @"SID.4.5",
                            Type = @"Component",
                            Position = @"SID.4.5",
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
                            Id = @"SID.4.6",
                            Type = @"Component",
                            Position = @"SID.4.6",
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
                            Id = @"SID.4.7",
                            Type = @"Component",
                            Position = @"SID.4.7",
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
                            Id = @"SID.4.8",
                            Type = @"Component",
                            Position = @"SID.4.8",
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
                            Id = @"SID.4.9",
                            Type = @"Component",
                            Position = @"SID.4.9",
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

        _substanceManufacturerIdentifier = new HL7V26Field
        {
            field = message[@"SID"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceManufacturerIdentifier.field.FieldRepetitions != null && _substanceManufacturerIdentifier.field.FieldRepetitions.Count > 0)
        {
            _substanceManufacturerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_substanceManufacturerIdentifier, fieldData);
        }

        return _substanceManufacturerIdentifier;
    } 
}
    }
}
