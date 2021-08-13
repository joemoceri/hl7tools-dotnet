using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPDC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PDC"; } }

        public string SegmentId { get { return @"PDC"; } }
        
        public string LongName { get { return @"Product Detail Country"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V23SegmentPDC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _manufacturerDistributor;

public HL7V23Field ManufacturerDistributor
{
    get
    {
        if (_manufacturerDistributor != null)
        {
            return _manufacturerDistributor;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.1",
            Type = @"Field",
            Position = @"PDC.1",
            Name = @"Manufacturer/Distributor",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identity of the manufacturer/distributor",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PDC.1.1",
                            Type = @"Component",
                            Position = @"PDC.1.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.2",
                            Type = @"Component",
                            Position = @"PDC.1.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.3",
                            Type = @"Component",
                            Position = @"PDC.1.3",
                            Name = @"ID Number",
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
                            Id = @"PDC.1.4",
                            Type = @"Component",
                            Position = @"PDC.1.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.5",
                            Type = @"Component",
                            Position = @"PDC.1.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.6",
                            Type = @"Component",
                            Position = @"PDC.1.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PDC.1.6.1",
                            Type = @"SubComponent",
                            Position = @"PDC.1.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.6.2",
                            Type = @"SubComponent",
                            Position = @"PDC.1.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.6.3",
                            Type = @"SubComponent",
                            Position = @"PDC.1.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.7",
                            Type = @"Component",
                            Position = @"PDC.1.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.8",
                            Type = @"Component",
                            Position = @"PDC.1.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PDC.1.8.1",
                            Type = @"SubComponent",
                            Position = @"PDC.1.8.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.8.2",
                            Type = @"SubComponent",
                            Position = @"PDC.1.8.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.8.3",
                            Type = @"SubComponent",
                            Position = @"PDC.1.8.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _manufacturerDistributor = new HL7V23Field
        {
            field = message[@"PDC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_manufacturerDistributor.field.FieldRepetitions != null && _manufacturerDistributor.field.FieldRepetitions.Count > 0)
        {
            _manufacturerDistributor.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_manufacturerDistributor, fieldData);
        }

        return _manufacturerDistributor;
    } 
}

internal HL7V23Field _country;

public HL7V23Field Country
{
    get
    {
        if (_country != null)
        {
            return _country;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.2",
            Type = @"Field",
            Position = @"PDC.2",
            Name = @"Country",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the country to which this product detail is relevant.  ISO 3166 provides a list of country codes that may be used",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PDC.2.1",
                            Type = @"Component",
                            Position = @"PDC.2.1",
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
                            Id = @"PDC.2.2",
                            Type = @"Component",
                            Position = @"PDC.2.2",
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
                            Id = @"PDC.2.3",
                            Type = @"Component",
                            Position = @"PDC.2.3",
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
                            Id = @"PDC.2.4",
                            Type = @"Component",
                            Position = @"PDC.2.4",
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
                            Id = @"PDC.2.5",
                            Type = @"Component",
                            Position = @"PDC.2.5",
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
                            Id = @"PDC.2.6",
                            Type = @"Component",
                            Position = @"PDC.2.6",
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

        _country = new HL7V23Field
        {
            field = message[@"PDC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_country.field.FieldRepetitions != null && _country.field.FieldRepetitions.Count > 0)
        {
            _country.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_country, fieldData);
        }

        return _country;
    } 
}

internal HL7V23Field _brandName;

public HL7V23Field BrandName
{
    get
    {
        if (_brandName != null)
        {
            return _brandName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.3",
            Type = @"Field",
            Position = @"PDC.3",
            Name = @"Brand Name",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name under which the product is marketed by this manufacturer",
            Sample = @"",
            Fields = null
        }

        _brandName = new HL7V23Field
        {
            field = message[@"PDC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_brandName.field.FieldRepetitions != null && _brandName.field.FieldRepetitions.Count > 0)
        {
            _brandName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_brandName, fieldData);
        }

        return _brandName;
    } 
}

internal HL7V23Field _deviceFamilyName;

public HL7V23Field DeviceFamilyName
{
    get
    {
        if (_deviceFamilyName != null)
        {
            return _deviceFamilyName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.4",
            Type = @"Field",
            Position = @"PDC.4",
            Name = @"Device Family Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name used by the manufacturer to describe the family of products to which this product belongs",
            Sample = @"",
            Fields = null
        }

        _deviceFamilyName = new HL7V23Field
        {
            field = message[@"PDC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deviceFamilyName.field.FieldRepetitions != null && _deviceFamilyName.field.FieldRepetitions.Count > 0)
        {
            _deviceFamilyName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_deviceFamilyName, fieldData);
        }

        return _deviceFamilyName;
    } 
}

internal HL7V23Field _genericName;

public HL7V23Field GenericName
{
    get
    {
        if (_genericName != null)
        {
            return _genericName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.5",
            Type = @"Field",
            Position = @"PDC.5",
            Name = @"Generic Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name generically used to identify the product",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PDC.5.1",
                            Type = @"Component",
                            Position = @"PDC.5.1",
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
                            Id = @"PDC.5.2",
                            Type = @"Component",
                            Position = @"PDC.5.2",
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
                            Id = @"PDC.5.3",
                            Type = @"Component",
                            Position = @"PDC.5.3",
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
                            Id = @"PDC.5.4",
                            Type = @"Component",
                            Position = @"PDC.5.4",
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
                            Id = @"PDC.5.5",
                            Type = @"Component",
                            Position = @"PDC.5.5",
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
                            Id = @"PDC.5.6",
                            Type = @"Component",
                            Position = @"PDC.5.6",
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

        _genericName = new HL7V23Field
        {
            field = message[@"PDC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_genericName.field.FieldRepetitions != null && _genericName.field.FieldRepetitions.Count > 0)
        {
            _genericName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_genericName, fieldData);
        }

        return _genericName;
    } 
}

internal HL7V23Field _modelIdentifier;

public HL7V23Field ModelIdentifier
{
    get
    {
        if (_modelIdentifier != null)
        {
            return _modelIdentifier;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.6",
            Type = @"Field",
            Position = @"PDC.6",
            Name = @"Model Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the manufacturer’s model identifier for the product",
            Sample = @"",
            Fields = null
        }

        _modelIdentifier = new HL7V23Field
        {
            field = message[@"PDC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_modelIdentifier.field.FieldRepetitions != null && _modelIdentifier.field.FieldRepetitions.Count > 0)
        {
            _modelIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_modelIdentifier, fieldData);
        }

        return _modelIdentifier;
    } 
}

internal HL7V23Field _catalogueIdentifier;

public HL7V23Field CatalogueIdentifier
{
    get
    {
        if (_catalogueIdentifier != null)
        {
            return _catalogueIdentifier;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.7",
            Type = @"Field",
            Position = @"PDC.7",
            Name = @"Catalogue Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the manufacturer’s catalogue identifier for the product",
            Sample = @"",
            Fields = null
        }

        _catalogueIdentifier = new HL7V23Field
        {
            field = message[@"PDC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_catalogueIdentifier.field.FieldRepetitions != null && _catalogueIdentifier.field.FieldRepetitions.Count > 0)
        {
            _catalogueIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_catalogueIdentifier, fieldData);
        }

        return _catalogueIdentifier;
    } 
}

internal HL7V23Field _otherIdentifier;

public HL7V23Field OtherIdentifier
{
    get
    {
        if (_otherIdentifier != null)
        {
            return _otherIdentifier;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.8",
            Type = @"Field",
            Position = @"PDC.8",
            Name = @"Other Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains any other identifier used to for the product",
            Sample = @"",
            Fields = null
        }

        _otherIdentifier = new HL7V23Field
        {
            field = message[@"PDC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_otherIdentifier.field.FieldRepetitions != null && _otherIdentifier.field.FieldRepetitions.Count > 0)
        {
            _otherIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_otherIdentifier, fieldData);
        }

        return _otherIdentifier;
    } 
}

internal HL7V23Field _productCode;

public HL7V23Field ProductCode
{
    get
    {
        if (_productCode != null)
        {
            return _productCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.9",
            Type = @"Field",
            Position = @"PDC.9",
            Name = @"Product Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the product code from an external coding system such as that used by the CDRH at the FDA",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PDC.9.1",
                            Type = @"Component",
                            Position = @"PDC.9.1",
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
                            Id = @"PDC.9.2",
                            Type = @"Component",
                            Position = @"PDC.9.2",
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
                            Id = @"PDC.9.3",
                            Type = @"Component",
                            Position = @"PDC.9.3",
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
                            Id = @"PDC.9.4",
                            Type = @"Component",
                            Position = @"PDC.9.4",
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
                            Id = @"PDC.9.5",
                            Type = @"Component",
                            Position = @"PDC.9.5",
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
                            Id = @"PDC.9.6",
                            Type = @"Component",
                            Position = @"PDC.9.6",
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

        _productCode = new HL7V23Field
        {
            field = message[@"PDC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productCode.field.FieldRepetitions != null && _productCode.field.FieldRepetitions.Count > 0)
        {
            _productCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_productCode, fieldData);
        }

        return _productCode;
    } 
}

internal HL7V23Field _marketingBasis;

public HL7V23Field MarketingBasis
{
    get
    {
        if (_marketingBasis != null)
        {
            return _marketingBasis;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.10",
            Type = @"Field",
            Position = @"PDC.10",
            Name = @"Marketing Basis",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0330",
            TableName = @"Marketing basis",
            Description = @"This field contains the basis for marketing approval.  Refer to HL7 table 0330 - Marketing basis for valid values",
            Sample = @"",
            Fields = null
        }

        _marketingBasis = new HL7V23Field
        {
            field = message[@"PDC"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_marketingBasis.field.FieldRepetitions != null && _marketingBasis.field.FieldRepetitions.Count > 0)
        {
            _marketingBasis.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_marketingBasis, fieldData);
        }

        return _marketingBasis;
    } 
}

internal HL7V23Field _marketingApprovalIdentifier;

public HL7V23Field MarketingApprovalIdentifier
{
    get
    {
        if (_marketingApprovalIdentifier != null)
        {
            return _marketingApprovalIdentifier;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.11",
            Type = @"Field",
            Position = @"PDC.11",
            Name = @"Marketing Approval Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the designation or description of the marketing basis",
            Sample = @"",
            Fields = null
        }

        _marketingApprovalIdentifier = new HL7V23Field
        {
            field = message[@"PDC"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_marketingApprovalIdentifier.field.FieldRepetitions != null && _marketingApprovalIdentifier.field.FieldRepetitions.Count > 0)
        {
            _marketingApprovalIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_marketingApprovalIdentifier, fieldData);
        }

        return _marketingApprovalIdentifier;
    } 
}

internal HL7V23Field _labeledShelfLife;

public HL7V23Field LabeledShelfLife
{
    get
    {
        if (_labeledShelfLife != null)
        {
            return _labeledShelfLife;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.12",
            Type = @"Field",
            Position = @"PDC.12",
            Name = @"Labeled Shelf Life",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the shelf life of the product as labeled.  This will usually be in months or years.  If there is no shelf life indicated in the product labeling, this field will be empty",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PDC.12.1",
                            Type = @"Component",
                            Position = @"PDC.12.1",
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
                            Id = @"PDC.12.2",
                            Type = @"Component",
                            Position = @"PDC.12.2",
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

        _labeledShelfLife = new HL7V23Field
        {
            field = message[@"PDC"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_labeledShelfLife.field.FieldRepetitions != null && _labeledShelfLife.field.FieldRepetitions.Count > 0)
        {
            _labeledShelfLife.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_labeledShelfLife, fieldData);
        }

        return _labeledShelfLife;
    } 
}

internal HL7V23Field _expectedShelfLife;

public HL7V23Field ExpectedShelfLife
{
    get
    {
        if (_expectedShelfLife != null)
        {
            return _expectedShelfLife;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.13",
            Type = @"Field",
            Position = @"PDC.13",
            Name = @"Expected Shelf Life",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the shelf life of the product expected by the manufacturer.  This will usually be in months or years",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PDC.13.1",
                            Type = @"Component",
                            Position = @"PDC.13.1",
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
                            Id = @"PDC.13.2",
                            Type = @"Component",
                            Position = @"PDC.13.2",
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

        _expectedShelfLife = new HL7V23Field
        {
            field = message[@"PDC"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedShelfLife.field.FieldRepetitions != null && _expectedShelfLife.field.FieldRepetitions.Count > 0)
        {
            _expectedShelfLife.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_expectedShelfLife, fieldData);
        }

        return _expectedShelfLife;
    } 
}

internal HL7V23Field _dateFirstMarked;

public HL7V23Field DateFirstMarked
{
    get
    {
        if (_dateFirstMarked != null)
        {
            return _dateFirstMarked;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.14",
            Type = @"Field",
            Position = @"PDC.14",
            Name = @"Date First Marked",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the product was first marketed in the country",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PDC.14.1",
                            Type = @"Component",
                            Position = @"PDC.14.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dateFirstMarked = new HL7V23Field
        {
            field = message[@"PDC"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateFirstMarked.field.FieldRepetitions != null && _dateFirstMarked.field.FieldRepetitions.Count > 0)
        {
            _dateFirstMarked.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dateFirstMarked, fieldData);
        }

        return _dateFirstMarked;
    } 
}

internal HL7V23Field _dateLastMarked;

public HL7V23Field DateLastMarked
{
    get
    {
        if (_dateLastMarked != null)
        {
            return _dateLastMarked;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PDC.15",
            Type = @"Field",
            Position = @"PDC.15",
            Name = @"Date Last Marked",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the product was last marketed in the country.  This field will be omitted if the product is still being marketed",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PDC.15.1",
                            Type = @"Component",
                            Position = @"PDC.15.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dateLastMarked = new HL7V23Field
        {
            field = message[@"PDC"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateLastMarked.field.FieldRepetitions != null && _dateLastMarked.field.FieldRepetitions.Count > 0)
        {
            _dateLastMarked.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dateLastMarked, fieldData);
        }

        return _dateLastMarked;
    } 
}
    }
}
