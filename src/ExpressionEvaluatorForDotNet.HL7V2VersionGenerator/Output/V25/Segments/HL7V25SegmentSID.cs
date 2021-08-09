using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentSID
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SID"; } }

        public string SegmentId { get { return @"SID"; } }
        
        public string LongName { get { return @"Substance Identifier"; } }
        
        public string Description { get { return @"The Substance Identifier segment contains data necessary to identify the substance (e.g., reagents) used in the production of analytical test results. The combination of these fields must uniquely identify the substance, i.e., depending on the manufacturer all or some fields are required (this is the reason the optionality is 'C' (conditional)). If the analysis requires multiple substances, this segment is repeated for each substance. The segment(s) should be attached to the TCD segment.

Another purpose of this segment is to transfer the control manufacturer, lot, etc. information for control specimens. In this case the SID segment should be attached to the SAC segment describing the container with the control specimen. "; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SID.1",
                            Type = @"Field",
                            Position = @"SID.1",
                            Name = @"Application / Method Identifier",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the application / method used for the analysis.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SID.4",
                            Type = @"Field",
                            Position = @"SID.4",
                            Name = @"Substance Manufacturer Identifier",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0385",
                            TableName = @"Manufacturer identifier",
                            Description = @"This field identifies the manufacturer of this substance. Refer to User-defined Table 0451 - Manufacturer identifier for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V25SegmentSID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field applicationMethodIdentifier;

public HL7V25Field ApplicationMethodIdentifier
{
    get
    {
        if (applicationMethodIdentifier != null)
        {
            return applicationMethodIdentifier;
        }

        applicationMethodIdentifier = new HL7V25Field
        {
            field = message[@"SID"][1],
            Id = @"SID.1",
            Type = @"Field",
            Position = @"SID.1",
            Name = @"Application / Method Identifier",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the application / method used for the analysis.",
            Sample = @"",
        };

        // check for repetitions
        if (applicationMethodIdentifier.field.FieldRepetitions != null && applicationMethodIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(applicationMethodIdentifier.Id));
            applicationMethodIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(applicationMethodIdentifier, fieldData);
        }

        return applicationMethodIdentifier;
    } 
}

internal HL7V25Field substanceLotNumber;

public HL7V25Field SubstanceLotNumber
{
    get
    {
        if (substanceLotNumber != null)
        {
            return substanceLotNumber;
        }

        substanceLotNumber = new HL7V25Field
        {
            field = message[@"SID"][2],
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
        };

        // check for repetitions
        if (substanceLotNumber.field.FieldRepetitions != null && substanceLotNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(substanceLotNumber.Id));
            substanceLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(substanceLotNumber, fieldData);
        }

        return substanceLotNumber;
    } 
}

internal HL7V25Field substanceContainerIdentifier;

public HL7V25Field SubstanceContainerIdentifier
{
    get
    {
        if (substanceContainerIdentifier != null)
        {
            return substanceContainerIdentifier;
        }

        substanceContainerIdentifier = new HL7V25Field
        {
            field = message[@"SID"][3],
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
        };

        // check for repetitions
        if (substanceContainerIdentifier.field.FieldRepetitions != null && substanceContainerIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(substanceContainerIdentifier.Id));
            substanceContainerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(substanceContainerIdentifier, fieldData);
        }

        return substanceContainerIdentifier;
    } 
}

internal HL7V25Field substanceManufacturerIdentifier;

public HL7V25Field SubstanceManufacturerIdentifier
{
    get
    {
        if (substanceManufacturerIdentifier != null)
        {
            return substanceManufacturerIdentifier;
        }

        substanceManufacturerIdentifier = new HL7V25Field
        {
            field = message[@"SID"][4],
            Id = @"SID.4",
            Type = @"Field",
            Position = @"SID.4",
            Name = @"Substance Manufacturer Identifier",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0385",
            TableName = @"Manufacturer identifier",
            Description = @"This field identifies the manufacturer of this substance. Refer to User-defined Table 0451 - Manufacturer identifier for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (substanceManufacturerIdentifier.field.FieldRepetitions != null && substanceManufacturerIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(substanceManufacturerIdentifier.Id));
            substanceManufacturerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(substanceManufacturerIdentifier, fieldData);
        }

        return substanceManufacturerIdentifier;
    } 
}
    }
}
