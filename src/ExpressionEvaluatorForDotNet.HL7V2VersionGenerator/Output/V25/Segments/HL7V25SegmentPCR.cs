using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentPCR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PCR"; } }

        public string SegmentId { get { return @"PCR"; } }
        
        public string LongName { get { return @"Possible Causal Relationship"; } }
        
        public string Description { get { return @"The PCR segment is used to communicate a potential or suspected relationship between a product (drug or device) or test and an event with detrimental effect on a patient. This segment identifies a potential causal relationship between the product identified in this segment and the event identified in the PEO segment."; } }
        
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

        public HL7V25SegmentPCR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _implicatedProduct;

public HL7V25Field ImplicatedProduct
{
    get
    {
        if (_implicatedProduct != null)
        {
            return _implicatedProduct;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.1",
            Type = @"Field",
            Position = @"PCR.1",
            Name = @"Implicated Product",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the coded identity of the product (drug, device, etc.) which is possibly causally related to the event. Includes the product identity number such as NDC, model or catalogue numbers. If a coded value is not available for the product a text description can be included as the second component of the CE data.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.1.1",
                            Type = @"Component",
                            Position = @"PCR.1.1",
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
                            Id = @"PCR.1.2",
                            Type = @"Component",
                            Position = @"PCR.1.2",
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
                            Id = @"PCR.1.3",
                            Type = @"Component",
                            Position = @"PCR.1.3",
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
                            Id = @"PCR.1.4",
                            Type = @"Component",
                            Position = @"PCR.1.4",
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
                            Id = @"PCR.1.5",
                            Type = @"Component",
                            Position = @"PCR.1.5",
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
                            Id = @"PCR.1.6",
                            Type = @"Component",
                            Position = @"PCR.1.6",
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

        _implicatedProduct = new HL7V25Field
        {
            field = message[@"PCR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_implicatedProduct.field.FieldRepetitions != null && _implicatedProduct.field.FieldRepetitions.Count > 0)
        {
            _implicatedProduct.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_implicatedProduct, fieldData);
        }

        return _implicatedProduct;
    } 
}

internal HL7V25Field _genericProduct;

public HL7V25Field GenericProduct
{
    get
    {
        if (_genericProduct != null)
        {
            return _genericProduct;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.2",
            Type = @"Field",
            Position = @"PCR.2",
            Name = @"Generic Product",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0249",
            TableName = @"Generic Product",
            Description = @"This field indicates whether the product used was a generic or a branded product. Refer to User-defined Table 0249 - Generic product for suggested values.",
            Sample = @"",
            Fields = null
        }

        _genericProduct = new HL7V25Field
        {
            field = message[@"PCR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_genericProduct.field.FieldRepetitions != null && _genericProduct.field.FieldRepetitions.Count > 0)
        {
            _genericProduct.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_genericProduct, fieldData);
        }

        return _genericProduct;
    } 
}

internal HL7V25Field _productClass;

public HL7V25Field ProductClass
{
    get
    {
        if (_productClass != null)
        {
            return _productClass;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.3",
            Type = @"Field",
            Position = @"PCR.3",
            Name = @"Product Class",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the coded classification of the implicated product. For drugs, this would usually be the drug class - calcium channel blocking agents for nifedipine for example. For other products it would be the generic type of device, e.g., urinary catheter, cardiac pacemaker. If a coded value is not available for the class, a text description can be included.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.3.1",
                            Type = @"Component",
                            Position = @"PCR.3.1",
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
                            Id = @"PCR.3.2",
                            Type = @"Component",
                            Position = @"PCR.3.2",
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
                            Id = @"PCR.3.3",
                            Type = @"Component",
                            Position = @"PCR.3.3",
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
                            Id = @"PCR.3.4",
                            Type = @"Component",
                            Position = @"PCR.3.4",
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
                            Id = @"PCR.3.5",
                            Type = @"Component",
                            Position = @"PCR.3.5",
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
                            Id = @"PCR.3.6",
                            Type = @"Component",
                            Position = @"PCR.3.6",
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

        _productClass = new HL7V25Field
        {
            field = message[@"PCR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productClass.field.FieldRepetitions != null && _productClass.field.FieldRepetitions.Count > 0)
        {
            _productClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productClass, fieldData);
        }

        return _productClass;
    } 
}

internal HL7V25Field _totalDurationOfTherapy;

public HL7V25Field TotalDurationOfTherapy
{
    get
    {
        if (_totalDurationOfTherapy != null)
        {
            return _totalDurationOfTherapy;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.4",
            Type = @"Field",
            Position = @"PCR.4",
            Name = @"Total Duration Of Therapy",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field represents the total duration of therapy with product listed. The treatment at the current dose and schedule are indicted in the quantity timing attribute of the RXE segment but the patient may have been treated for some time previously at a different dose or on a different schedule. The quantity in the second component of the CQ should be a time quantity.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.4.1",
                            Type = @"Component",
                            Position = @"PCR.4.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCR.4.2",
                            Type = @"Component",
                            Position = @"PCR.4.2",
                            Name = @"Units",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PCR.4.2.1",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.1",
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
                            Id = @"PCR.4.2.2",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.2",
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
                            Id = @"PCR.4.2.3",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.3",
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
                            Id = @"PCR.4.2.4",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.4",
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
                            Id = @"PCR.4.2.5",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.5",
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
                            Id = @"PCR.4.2.6",
                            Type = @"SubComponent",
                            Position = @"PCR.4.2.6",
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
                        }
        }

        _totalDurationOfTherapy = new HL7V25Field
        {
            field = message[@"PCR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalDurationOfTherapy.field.FieldRepetitions != null && _totalDurationOfTherapy.field.FieldRepetitions.Count > 0)
        {
            _totalDurationOfTherapy.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_totalDurationOfTherapy, fieldData);
        }

        return _totalDurationOfTherapy;
    } 
}

internal HL7V25Field _productManufactureDate;

public HL7V25Field ProductManufactureDate
{
    get
    {
        if (_productManufactureDate != null)
        {
            return _productManufactureDate;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.5",
            Type = @"Field",
            Position = @"PCR.5",
            Name = @"Product Manufacture Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date the product was manufactured.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.5.1",
                            Type = @"Component",
                            Position = @"PCR.5.1",
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
                            Id = @"PCR.5.2",
                            Type = @"Component",
                            Position = @"PCR.5.2",
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

        _productManufactureDate = new HL7V25Field
        {
            field = message[@"PCR"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productManufactureDate.field.FieldRepetitions != null && _productManufactureDate.field.FieldRepetitions.Count > 0)
        {
            _productManufactureDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productManufactureDate, fieldData);
        }

        return _productManufactureDate;
    } 
}

internal HL7V25Field _productExpirationDate;

public HL7V25Field ProductExpirationDate
{
    get
    {
        if (_productExpirationDate != null)
        {
            return _productExpirationDate;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.6",
            Type = @"Field",
            Position = @"PCR.6",
            Name = @"Product Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date indicated on the product packaging.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.6.1",
                            Type = @"Component",
                            Position = @"PCR.6.1",
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
                            Id = @"PCR.6.2",
                            Type = @"Component",
                            Position = @"PCR.6.2",
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

        _productExpirationDate = new HL7V25Field
        {
            field = message[@"PCR"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productExpirationDate.field.FieldRepetitions != null && _productExpirationDate.field.FieldRepetitions.Count > 0)
        {
            _productExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productExpirationDate, fieldData);
        }

        return _productExpirationDate;
    } 
}

internal HL7V25Field _productImplantationDate;

public HL7V25Field ProductImplantationDate
{
    get
    {
        if (_productImplantationDate != null)
        {
            return _productImplantationDate;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.7",
            Type = @"Field",
            Position = @"PCR.7",
            Name = @"Product Implantation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If an implantable medical device, this field identifies the date device was implanted.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.7.1",
                            Type = @"Component",
                            Position = @"PCR.7.1",
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
                            Id = @"PCR.7.2",
                            Type = @"Component",
                            Position = @"PCR.7.2",
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

        _productImplantationDate = new HL7V25Field
        {
            field = message[@"PCR"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productImplantationDate.field.FieldRepetitions != null && _productImplantationDate.field.FieldRepetitions.Count > 0)
        {
            _productImplantationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productImplantationDate, fieldData);
        }

        return _productImplantationDate;
    } 
}

internal HL7V25Field _productExplantationDate;

public HL7V25Field ProductExplantationDate
{
    get
    {
        if (_productExplantationDate != null)
        {
            return _productExplantationDate;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.8",
            Type = @"Field",
            Position = @"PCR.8",
            Name = @"Product Explantation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If an implantable medical device and it was removed, the field identifies the date it was removed.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.8.1",
                            Type = @"Component",
                            Position = @"PCR.8.1",
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
                            Id = @"PCR.8.2",
                            Type = @"Component",
                            Position = @"PCR.8.2",
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

        _productExplantationDate = new HL7V25Field
        {
            field = message[@"PCR"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productExplantationDate.field.FieldRepetitions != null && _productExplantationDate.field.FieldRepetitions.Count > 0)
        {
            _productExplantationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productExplantationDate, fieldData);
        }

        return _productExplantationDate;
    } 
}

internal HL7V25Field _singleUseDevice;

public HL7V25Field SingleUseDevice
{
    get
    {
        if (_singleUseDevice != null)
        {
            return _singleUseDevice;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.9",
            Type = @"Field",
            Position = @"PCR.9",
            Name = @"Single Use Device",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0244",
            TableName = @"Single Use Device",
            Description = @"This field indicates whether the product was designed for a single use. Refer to User-defined Table 0244 - Single use device for suggested values.",
            Sample = @"",
            Fields = null
        }

        _singleUseDevice = new HL7V25Field
        {
            field = message[@"PCR"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_singleUseDevice.field.FieldRepetitions != null && _singleUseDevice.field.FieldRepetitions.Count > 0)
        {
            _singleUseDevice.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_singleUseDevice, fieldData);
        }

        return _singleUseDevice;
    } 
}

internal HL7V25Field _indicationForProductUse;

public HL7V25Field IndicationForProductUse
{
    get
    {
        if (_indicationForProductUse != null)
        {
            return _indicationForProductUse;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.10",
            Type = @"Field",
            Position = @"PCR.10",
            Name = @"Indication For Product Use",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains coded representation of the problem or diagnosis for which the product was used.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.10.1",
                            Type = @"Component",
                            Position = @"PCR.10.1",
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
                            Id = @"PCR.10.2",
                            Type = @"Component",
                            Position = @"PCR.10.2",
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
                            Id = @"PCR.10.3",
                            Type = @"Component",
                            Position = @"PCR.10.3",
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
                            Id = @"PCR.10.4",
                            Type = @"Component",
                            Position = @"PCR.10.4",
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
                            Id = @"PCR.10.5",
                            Type = @"Component",
                            Position = @"PCR.10.5",
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
                            Id = @"PCR.10.6",
                            Type = @"Component",
                            Position = @"PCR.10.6",
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

        _indicationForProductUse = new HL7V25Field
        {
            field = message[@"PCR"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_indicationForProductUse.field.FieldRepetitions != null && _indicationForProductUse.field.FieldRepetitions.Count > 0)
        {
            _indicationForProductUse.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_indicationForProductUse, fieldData);
        }

        return _indicationForProductUse;
    } 
}

internal HL7V25Field _productProblem;

public HL7V25Field ProductProblem
{
    get
    {
        if (_productProblem != null)
        {
            return _productProblem;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.11",
            Type = @"Field",
            Position = @"PCR.11",
            Name = @"Product Problem",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0245",
            TableName = @"Product Problem",
            Description = @"A product problem would exist if a product malfunction could lead to death or serious injury. Refer to User-defined Table 0245 - Product problem for suggested values.",
            Sample = @"",
            Fields = null
        }

        _productProblem = new HL7V25Field
        {
            field = message[@"PCR"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productProblem.field.FieldRepetitions != null && _productProblem.field.FieldRepetitions.Count > 0)
        {
            _productProblem.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productProblem, fieldData);
        }

        return _productProblem;
    } 
}

internal HL7V25Field _productSerialLotNumber;

public HL7V25Field ProductSerialLotNumber
{
    get
    {
        if (_productSerialLotNumber != null)
        {
            return _productSerialLotNumber;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.12",
            Type = @"Field",
            Position = @"PCR.12",
            Name = @"Product Serial/Lot Number",
            Length = 30,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is an alphanumeric descriptor which identifies the specific item or lot of drug. This descriptor would normally be obtained from the package labeling or item itself.",
            Sample = @"",
            Fields = null
        }

        _productSerialLotNumber = new HL7V25Field
        {
            field = message[@"PCR"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productSerialLotNumber.field.FieldRepetitions != null && _productSerialLotNumber.field.FieldRepetitions.Count > 0)
        {
            _productSerialLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productSerialLotNumber, fieldData);
        }

        return _productSerialLotNumber;
    } 
}

internal HL7V25Field _productAvailableForInspection;

public HL7V25Field ProductAvailableForInspection
{
    get
    {
        if (_productAvailableForInspection != null)
        {
            return _productAvailableForInspection;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.13",
            Type = @"Field",
            Position = @"PCR.13",
            Name = @"Product Available For Inspection",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0246",
            TableName = @"Product Available for Inspection",
            Description = @"This field indicates that the product is available for analysis. User-defined Table 0246 -Product available for inspection is used as the HL7 identifier for the user-defined table of values for this field . If the product was returned to the manufacturer, this would be indicated by including the date it was returned in the date product returned to manufacturer element.",
            Sample = @"",
            Fields = null
        }

        _productAvailableForInspection = new HL7V25Field
        {
            field = message[@"PCR"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productAvailableForInspection.field.FieldRepetitions != null && _productAvailableForInspection.field.FieldRepetitions.Count > 0)
        {
            _productAvailableForInspection.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productAvailableForInspection, fieldData);
        }

        return _productAvailableForInspection;
    } 
}

internal HL7V25Field _productEvaluationPerformed;

public HL7V25Field ProductEvaluationPerformed
{
    get
    {
        if (_productEvaluationPerformed != null)
        {
            return _productEvaluationPerformed;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.14",
            Type = @"Field",
            Position = @"PCR.14",
            Name = @"Product Evaluation Performed",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the type of product evaluation performed. The evaluation codes listed in SubPart B of the Coding Manual for FDA Form 3500A, Type of Evaluation Performed may be used. If no codes are available, text may be sent in the second component of the field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.14.1",
                            Type = @"Component",
                            Position = @"PCR.14.1",
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
                            Id = @"PCR.14.2",
                            Type = @"Component",
                            Position = @"PCR.14.2",
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
                            Id = @"PCR.14.3",
                            Type = @"Component",
                            Position = @"PCR.14.3",
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
                            Id = @"PCR.14.4",
                            Type = @"Component",
                            Position = @"PCR.14.4",
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
                            Id = @"PCR.14.5",
                            Type = @"Component",
                            Position = @"PCR.14.5",
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
                            Id = @"PCR.14.6",
                            Type = @"Component",
                            Position = @"PCR.14.6",
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

        _productEvaluationPerformed = new HL7V25Field
        {
            field = message[@"PCR"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productEvaluationPerformed.field.FieldRepetitions != null && _productEvaluationPerformed.field.FieldRepetitions.Count > 0)
        {
            _productEvaluationPerformed.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productEvaluationPerformed, fieldData);
        }

        return _productEvaluationPerformed;
    } 
}

internal HL7V25Field _productEvaluationStatus;

public HL7V25Field ProductEvaluationStatus
{
    get
    {
        if (_productEvaluationStatus != null)
        {
            return _productEvaluationStatus;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.15",
            Type = @"Field",
            Position = @"PCR.15",
            Name = @"Product Evaluation Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0247",
            TableName = @"Status of Evaluation",
            Description = @"This field identifies the status of product evaluation. Subpart A Item H.3 of the Coding Manual for FDA Form 3500A may also be used. If no codes are available, text may be sent in the second component of the field. Refer to HL7 Table 0247 - Status of evaluation for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.15.1",
                            Type = @"Component",
                            Position = @"PCR.15.1",
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
                            Id = @"PCR.15.2",
                            Type = @"Component",
                            Position = @"PCR.15.2",
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
                            Id = @"PCR.15.3",
                            Type = @"Component",
                            Position = @"PCR.15.3",
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
                            Id = @"PCR.15.4",
                            Type = @"Component",
                            Position = @"PCR.15.4",
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
                            Id = @"PCR.15.5",
                            Type = @"Component",
                            Position = @"PCR.15.5",
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
                            Id = @"PCR.15.6",
                            Type = @"Component",
                            Position = @"PCR.15.6",
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

        _productEvaluationStatus = new HL7V25Field
        {
            field = message[@"PCR"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productEvaluationStatus.field.FieldRepetitions != null && _productEvaluationStatus.field.FieldRepetitions.Count > 0)
        {
            _productEvaluationStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productEvaluationStatus, fieldData);
        }

        return _productEvaluationStatus;
    } 
}

internal HL7V25Field _productEvaluationResults;

public HL7V25Field ProductEvaluationResults
{
    get
    {
        if (_productEvaluationResults != null)
        {
            return _productEvaluationResults;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.16",
            Type = @"Field",
            Position = @"PCR.16",
            Name = @"Product Evaluation Results",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the results of the product evaluation.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.16.1",
                            Type = @"Component",
                            Position = @"PCR.16.1",
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
                            Id = @"PCR.16.2",
                            Type = @"Component",
                            Position = @"PCR.16.2",
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
                            Id = @"PCR.16.3",
                            Type = @"Component",
                            Position = @"PCR.16.3",
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
                            Id = @"PCR.16.4",
                            Type = @"Component",
                            Position = @"PCR.16.4",
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
                            Id = @"PCR.16.5",
                            Type = @"Component",
                            Position = @"PCR.16.5",
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
                            Id = @"PCR.16.6",
                            Type = @"Component",
                            Position = @"PCR.16.6",
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

        _productEvaluationResults = new HL7V25Field
        {
            field = message[@"PCR"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_productEvaluationResults.field.FieldRepetitions != null && _productEvaluationResults.field.FieldRepetitions.Count > 0)
        {
            _productEvaluationResults.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_productEvaluationResults, fieldData);
        }

        return _productEvaluationResults;
    } 
}

internal HL7V25Field _evaluatedProductSource;

public HL7V25Field EvaluatedProductSource
{
    get
    {
        if (_evaluatedProductSource != null)
        {
            return _evaluatedProductSource;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.17",
            Type = @"Field",
            Position = @"PCR.17",
            Name = @"Evaluated Product Source",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0248",
            TableName = @"Product source",
            Description = @"This field contains the source of the product evaluated. Refer to HL7 Table 0248 - Product source for valid values.",
            Sample = @"",
            Fields = null
        }

        _evaluatedProductSource = new HL7V25Field
        {
            field = message[@"PCR"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_evaluatedProductSource.field.FieldRepetitions != null && _evaluatedProductSource.field.FieldRepetitions.Count > 0)
        {
            _evaluatedProductSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_evaluatedProductSource, fieldData);
        }

        return _evaluatedProductSource;
    } 
}

internal HL7V25Field _dateProductReturnedToManufacturer;

public HL7V25Field DateProductReturnedToManufacturer
{
    get
    {
        if (_dateProductReturnedToManufacturer != null)
        {
            return _dateProductReturnedToManufacturer;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.18",
            Type = @"Field",
            Position = @"PCR.18",
            Name = @"Date Product Returned To Manufacturer",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If the product was returned to the manufacturer, this field contains the date it was returned may be reported.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PCR.18.1",
                            Type = @"Component",
                            Position = @"PCR.18.1",
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
                            Id = @"PCR.18.2",
                            Type = @"Component",
                            Position = @"PCR.18.2",
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

        _dateProductReturnedToManufacturer = new HL7V25Field
        {
            field = message[@"PCR"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateProductReturnedToManufacturer.field.FieldRepetitions != null && _dateProductReturnedToManufacturer.field.FieldRepetitions.Count > 0)
        {
            _dateProductReturnedToManufacturer.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_dateProductReturnedToManufacturer, fieldData);
        }

        return _dateProductReturnedToManufacturer;
    } 
}

internal HL7V25Field _deviceOperatorQualifications;

public HL7V25Field DeviceOperatorQualifications
{
    get
    {
        if (_deviceOperatorQualifications != null)
        {
            return _deviceOperatorQualifications;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.19",
            Type = @"Field",
            Position = @"PCR.19",
            Name = @"Device Operator Qualifications",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0242",
            TableName = @"Primary Observer's Qualification",
            Description = @"This field identifies the qualification of the person operating the device when the event occurred. Refer to HL7 Table 0242 - Primary observers qualification for valid values.",
            Sample = @"",
            Fields = null
        }

        _deviceOperatorQualifications = new HL7V25Field
        {
            field = message[@"PCR"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deviceOperatorQualifications.field.FieldRepetitions != null && _deviceOperatorQualifications.field.FieldRepetitions.Count > 0)
        {
            _deviceOperatorQualifications.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_deviceOperatorQualifications, fieldData);
        }

        return _deviceOperatorQualifications;
    } 
}

internal HL7V25Field _relatednessAssessment;

public HL7V25Field RelatednessAssessment
{
    get
    {
        if (_relatednessAssessment != null)
        {
            return _relatednessAssessment;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.20",
            Type = @"Field",
            Position = @"PCR.20",
            Name = @"Relatedness Assessment",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0250",
            TableName = @"Relatedness Assessment",
            Description = @"This field represents the assessment of relatedness of the product to the event. Refer to HL7 Table 0250 - Relatedness assessment for valid values.",
            Sample = @"",
            Fields = null
        }

        _relatednessAssessment = new HL7V25Field
        {
            field = message[@"PCR"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relatednessAssessment.field.FieldRepetitions != null && _relatednessAssessment.field.FieldRepetitions.Count > 0)
        {
            _relatednessAssessment.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_relatednessAssessment, fieldData);
        }

        return _relatednessAssessment;
    } 
}

internal HL7V25Field _actionTakenInResponseToTheEvent;

public HL7V25Field ActionTakenInResponseToTheEvent
{
    get
    {
        if (_actionTakenInResponseToTheEvent != null)
        {
            return _actionTakenInResponseToTheEvent;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.21",
            Type = @"Field",
            Position = @"PCR.21",
            Name = @"Action Taken In Response To The Event",
            Length = 2,
            Usage = @"O",
            Rpt = @"6",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0251",
            TableName = @"Action Taken in Response to the Event",
            Description = @"This field indicates the action taken as a result of the event. Segment may repeat if multiple categories of evidence are relevant. Refer to HL7 Table 0251 - Action taken in response to the event for valid values.",
            Sample = @"",
            Fields = null
        }

        _actionTakenInResponseToTheEvent = new HL7V25Field
        {
            field = message[@"PCR"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actionTakenInResponseToTheEvent.field.FieldRepetitions != null && _actionTakenInResponseToTheEvent.field.FieldRepetitions.Count > 0)
        {
            _actionTakenInResponseToTheEvent.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_actionTakenInResponseToTheEvent, fieldData);
        }

        return _actionTakenInResponseToTheEvent;
    } 
}

internal HL7V25Field _eventCausalityObservations;

public HL7V25Field EventCausalityObservations
{
    get
    {
        if (_eventCausalityObservations != null)
        {
            return _eventCausalityObservations;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.22",
            Type = @"Field",
            Position = @"PCR.22",
            Name = @"Event Causality Observations",
            Length = 2,
            Usage = @"O",
            Rpt = @"6",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0252",
            TableName = @"Causality Observations",
            Description = @"This field contains observations made about the event which may bear on causality. Refer to HL7 Table 0252 - Causality observations for valid values. Segment may repeat if multiple categories of evidence are relevant.",
            Sample = @"",
            Fields = null
        }

        _eventCausalityObservations = new HL7V25Field
        {
            field = message[@"PCR"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventCausalityObservations.field.FieldRepetitions != null && _eventCausalityObservations.field.FieldRepetitions.Count > 0)
        {
            _eventCausalityObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_eventCausalityObservations, fieldData);
        }

        return _eventCausalityObservations;
    } 
}

internal HL7V25Field _indirectExposureMechanism;

public HL7V25Field IndirectExposureMechanism
{
    get
    {
        if (_indirectExposureMechanism != null)
        {
            return _indirectExposureMechanism;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"PCR.23",
            Type = @"Field",
            Position = @"PCR.23",
            Name = @"Indirect Exposure Mechanism",
            Length = 1,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0253",
            TableName = @"Indirect exposure mechanism",
            Description = @"The patient identified in the PID segment, who experienced the event, might have been exposed to the potential causal product via an intermediary, e.g., a child might be exposed to a product through the placenta or in breast milk, or a transfusion recipient might be exposed via a blood product. If this is the case, the mechanism of product transmission is identified in this field, using the valid values in HL7 Table 0253 - Indirect exposure mechanism . If this field is populated, the identity of the person through whom the product was transmitted is contained in NK1 and RXE segments which follow.",
            Sample = @"",
            Fields = null
        }

        _indirectExposureMechanism = new HL7V25Field
        {
            field = message[@"PCR"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_indirectExposureMechanism.field.FieldRepetitions != null && _indirectExposureMechanism.field.FieldRepetitions.Count > 0)
        {
            _indirectExposureMechanism.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_indirectExposureMechanism, fieldData);
        }

        return _indirectExposureMechanism;
    } 
}
    }
}
