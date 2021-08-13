using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRXO
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXO"; } }

        public string SegmentId { get { return @"RXO"; } }
        
        public string LongName { get { return @"Pharmacy Prescription Order"; } }
        
        public string Description { get { return @"This is the ""master"" pharmacy order segment.  It contains order data not specific to components or additives.  Unlike the OBR, it does not contain status fields or other data that are results-only.

It can be used for any type of pharmacy order, including inpatient (unit dose and compound unit dose), outpatient, IVs, and hyperalimentation IVs (nutritional IVs).  
 
In addition to the pharmaceutical information, this segment contains additional data such as provider and text comments."; } }
        
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

        public HL7V22SegmentRXO(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _requestedGiveCode;

public HL7V22Field RequestedGiveCode
{
    get
    {
        if (_requestedGiveCode != null)
        {
            return _requestedGiveCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.1",
            Type = @"Field",
            Position = @"RXO.1",
            Name = @"Requested Give Code",
            Length = 100,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"identifier of the medical substance ordered to be given to the patient; it is equivalent to OBR-4-universal service ID code in function.  The request-to-dispense fields, which define the type and amount of what is to be issued to the patient (see RXO-10 requested dispense code, RXO-11-requested dispense amount, and RXO-12-requested dispense units) do not necessarily correlate with the instructions of what amount is to be ""given"" or administered with each dose, and may or may not be specified with the order.  For example, the ""give"" part of the order may convey the field-representation of give 15 mg of librium every 6 hours, while the request to dispense part of the order may convey issue 30 tablets of 10 MG generic equivalent for this outpatient prescription.  When the give code does not include the dosage form, use RXO-5-requested dosage form.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.1.1",
                            Type = @"Component",
                            Position = @"RXO.1.1",
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
                            Id = @"RXO.1.2",
                            Type = @"Component",
                            Position = @"RXO.1.2",
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
                            Id = @"RXO.1.3",
                            Type = @"Component",
                            Position = @"RXO.1.3",
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
                            Id = @"RXO.1.4",
                            Type = @"Component",
                            Position = @"RXO.1.4",
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
                            Id = @"RXO.1.5",
                            Type = @"Component",
                            Position = @"RXO.1.5",
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
                            Id = @"RXO.1.6",
                            Type = @"Component",
                            Position = @"RXO.1.6",
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
                        },
                        }
        }

        _requestedGiveCode = new HL7V22Field
        {
            field = message[@"RXO"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveCode.field.FieldRepetitions != null && _requestedGiveCode.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requestedGiveCode, fieldData);
        }

        return _requestedGiveCode;
    } 
}

internal HL7V22Field _requestedGiveAmountMinimum;

public HL7V22Field RequestedGiveAmountMinimum
{
    get
    {
        if (_requestedGiveAmountMinimum != null)
        {
            return _requestedGiveAmountMinimum;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.2",
            Type = @"Field",
            Position = @"RXO.2",
            Name = @"Requested Give Amount - Minimum",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"ordered amount.  In a variable dose order, this is the minimum ordered amount.  In a nonvarying dose order, this is the exact amount of the order

Note:This field is not a duplication of the first component of the quantity/timing field, since in non-Pharmacy orders, that component can be used to specify multiples of an ordered amount. 
 
Another way to say this is that, for pharmacy orders, the quantity component of the quantity/timing field refers to what is to be given out at each service interval; thus, in terms of the RX order, that first component always defaults to 1.  Hence, in the actual execution of the order, the value of 1 in the first component of the quantity/timing field always refers to one administration of the amount specified in this field (the Requested Give Amount field). ",
            Sample = @"",
            Fields = null
        }

        _requestedGiveAmountMinimum = new HL7V22Field
        {
            field = message[@"RXO"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveAmountMinimum.field.FieldRepetitions != null && _requestedGiveAmountMinimum.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveAmountMinimum.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requestedGiveAmountMinimum, fieldData);
        }

        return _requestedGiveAmountMinimum;
    } 
}

internal HL7V22Field _requestedGiveAmountMaximum;

public HL7V22Field RequestedGiveAmountMaximum
{
    get
    {
        if (_requestedGiveAmountMaximum != null)
        {
            return _requestedGiveAmountMaximum;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.3",
            Type = @"Field",
            Position = @"RXO.3",
            Name = @"Requested Give Amount - Maximum",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"in a variable dose order, this is the maximum ordered amount.  In a nonvarying dose order, this field is not used",
            Sample = @"",
            Fields = null
        }

        _requestedGiveAmountMaximum = new HL7V22Field
        {
            field = message[@"RXO"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveAmountMaximum.field.FieldRepetitions != null && _requestedGiveAmountMaximum.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveAmountMaximum.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requestedGiveAmountMaximum, fieldData);
        }

        return _requestedGiveAmountMaximum;
    } 
}

internal HL7V22Field _requestedGiveUnits;

public HL7V22Field RequestedGiveUnits
{
    get
    {
        if (_requestedGiveUnits != null)
        {
            return _requestedGiveUnits;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.4",
            Type = @"Field",
            Position = @"RXO.4",
            Name = @"Requested Give Units",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"units for the give amount.  
 
Note:These units can be a ""compound quantity""; i.e., the units may contain the word ""per.""  For example, micrograms per KG (micg/kg) is an acceptable value, which means that the units are micrograms per KG (of body weight).  See Chapter 7 for full definition of ISO+ units. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.4.1",
                            Type = @"Component",
                            Position = @"RXO.4.1",
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
                            Id = @"RXO.4.2",
                            Type = @"Component",
                            Position = @"RXO.4.2",
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
                            Id = @"RXO.4.3",
                            Type = @"Component",
                            Position = @"RXO.4.3",
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
                            Id = @"RXO.4.4",
                            Type = @"Component",
                            Position = @"RXO.4.4",
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
                            Id = @"RXO.4.5",
                            Type = @"Component",
                            Position = @"RXO.4.5",
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
                            Id = @"RXO.4.6",
                            Type = @"Component",
                            Position = @"RXO.4.6",
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
                        },
                        }
        }

        _requestedGiveUnits = new HL7V22Field
        {
            field = message[@"RXO"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveUnits.field.FieldRepetitions != null && _requestedGiveUnits.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requestedGiveUnits, fieldData);
        }

        return _requestedGiveUnits;
    } 
}

internal HL7V22Field _requestedDosageForm;

public HL7V22Field RequestedDosageForm
{
    get
    {
        if (_requestedDosageForm != null)
        {
            return _requestedDosageForm;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.5",
            Type = @"Field",
            Position = @"RXO.5",
            Name = @"Requested Dosage Form",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"use when both RXO-1-requested give code and RXO-10-requested dispense code do not specify the drug form",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.5.1",
                            Type = @"Component",
                            Position = @"RXO.5.1",
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
                            Id = @"RXO.5.2",
                            Type = @"Component",
                            Position = @"RXO.5.2",
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
                            Id = @"RXO.5.3",
                            Type = @"Component",
                            Position = @"RXO.5.3",
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
                            Id = @"RXO.5.4",
                            Type = @"Component",
                            Position = @"RXO.5.4",
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
                            Id = @"RXO.5.5",
                            Type = @"Component",
                            Position = @"RXO.5.5",
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
                            Id = @"RXO.5.6",
                            Type = @"Component",
                            Position = @"RXO.5.6",
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
                        },
                        }
        }

        _requestedDosageForm = new HL7V22Field
        {
            field = message[@"RXO"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDosageForm.field.FieldRepetitions != null && _requestedDosageForm.field.FieldRepetitions.Count > 0)
        {
            _requestedDosageForm.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requestedDosageForm, fieldData);
        }

        return _requestedDosageForm;
    } 
}

internal HL7V22Field _providersPharmacyInstructions;

public HL7V22Field ProvidersPharmacyInstructions
{
    get
    {
        if (_providersPharmacyInstructions != null)
        {
            return _providersPharmacyInstructions;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.6",
            Type = @"Field",
            Position = @"RXO.6",
            Name = @"Provider's Pharmacy Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"ordering provider's instructions to the pharmacy as a free text field",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.6.1",
                            Type = @"Component",
                            Position = @"RXO.6.1",
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
                            Id = @"RXO.6.2",
                            Type = @"Component",
                            Position = @"RXO.6.2",
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
                            Id = @"RXO.6.3",
                            Type = @"Component",
                            Position = @"RXO.6.3",
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
                            Id = @"RXO.6.4",
                            Type = @"Component",
                            Position = @"RXO.6.4",
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
                            Id = @"RXO.6.5",
                            Type = @"Component",
                            Position = @"RXO.6.5",
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
                            Id = @"RXO.6.6",
                            Type = @"Component",
                            Position = @"RXO.6.6",
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
                        },
                        }
        }

        _providersPharmacyInstructions = new HL7V22Field
        {
            field = message[@"RXO"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_providersPharmacyInstructions.field.FieldRepetitions != null && _providersPharmacyInstructions.field.FieldRepetitions.Count > 0)
        {
            _providersPharmacyInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_providersPharmacyInstructions, fieldData);
        }

        return _providersPharmacyInstructions;
    } 
}

internal HL7V22Field _providersAdministrationInstructions;

public HL7V22Field ProvidersAdministrationInstructions
{
    get
    {
        if (_providersAdministrationInstructions != null)
        {
            return _providersAdministrationInstructions;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.7",
            Type = @"Field",
            Position = @"RXO.7",
            Name = @"Provider's Administration Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"ordering provider's instructions to the patient or to the provider administering the drug as a free text field",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.7.1",
                            Type = @"Component",
                            Position = @"RXO.7.1",
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
                            Id = @"RXO.7.2",
                            Type = @"Component",
                            Position = @"RXO.7.2",
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
                            Id = @"RXO.7.3",
                            Type = @"Component",
                            Position = @"RXO.7.3",
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
                            Id = @"RXO.7.4",
                            Type = @"Component",
                            Position = @"RXO.7.4",
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
                            Id = @"RXO.7.5",
                            Type = @"Component",
                            Position = @"RXO.7.5",
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
                            Id = @"RXO.7.6",
                            Type = @"Component",
                            Position = @"RXO.7.6",
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
                        },
                        }
        }

        _providersAdministrationInstructions = new HL7V22Field
        {
            field = message[@"RXO"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_providersAdministrationInstructions.field.FieldRepetitions != null && _providersAdministrationInstructions.field.FieldRepetitions.Count > 0)
        {
            _providersAdministrationInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_providersAdministrationInstructions, fieldData);
        }

        return _providersAdministrationInstructions;
    } 
}

internal HL7V22Field _delivertoLocation;

public HL7V22Field DelivertoLocation
{
    get
    {
        if (_delivertoLocation != null)
        {
            return _delivertoLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.8",
            Type = @"Field",
            Position = @"RXO.8",
            Name = @"Deliver-to Location",
            Length = 12,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CM_LA1",
            DataTypeName = @"Location With Address Information",
            TableId = null,
            TableName = null,
            Description = @"the first component contains the inpatient or outpatient location to which the pharmacy is to deliver the drug (if applicable).  The default (null) value is the current census location for the patient.  Site specific table.  This component has the same form as PV1-3-assigned patient location.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.8.1",
                            Type = @"Component",
                            Position = @"RXO.8.1",
                            Name = @"Dispense / Deliver To Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_INTERNAL_LOCATION",
                            DataTypeName = @"Cm For Location Information In Hospital",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.8.1.1",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.1",
                            Name = @"Nurse Unit (station)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.1.2",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.1.3",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.1.4",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.4",
                            Name = @"Facility Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.1.5",
                            Type = @"SubComponent",
                            Position = @"RXO.8.1.5",
                            Name = @"Bed Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2",
                            Type = @"Component",
                            Position = @"RXO.8.2",
                            Name = @"Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component can be used to specify an address.  This could be used to fill mail orders to a patient or provider, or to account for home health care. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.1",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.1",
                            Name = @"Street Address",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.2",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.2",
                            Name = @"Other Designation",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.3",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.3",
                            Name = @"City",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.4",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.4",
                            Name = @"State Or Province",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.5",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.6",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.7",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.7",
                            Name = @"Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0190",
                            TableName = @"ADDRESS TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.2.8",
                            Type = @"SubComponent",
                            Position = @"RXO.8.2.8",
                            Name = @"Other Geographic Designation",
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
                        },}
                        },
                        }
        }

        _delivertoLocation = new HL7V22Field
        {
            field = message[@"RXO"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delivertoLocation.field.FieldRepetitions != null && _delivertoLocation.field.FieldRepetitions.Count > 0)
        {
            _delivertoLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_delivertoLocation, fieldData);
        }

        return _delivertoLocation;
    } 
}

internal HL7V22Field _allowSubstitutions;

public HL7V22Field AllowSubstitutions
{
    get
    {
        if (_allowSubstitutions != null)
        {
            return _allowSubstitutions;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.9",
            Type = @"Field",
            Position = @"RXO.9",
            Name = @"Allow Substitutions",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0161",
            TableName = @"ALLOW SUBSTITUTION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _allowSubstitutions = new HL7V22Field
        {
            field = message[@"RXO"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_allowSubstitutions.field.FieldRepetitions != null && _allowSubstitutions.field.FieldRepetitions.Count > 0)
        {
            _allowSubstitutions.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_allowSubstitutions, fieldData);
        }

        return _allowSubstitutions;
    } 
}

internal HL7V22Field _requestedDispenseCode;

public HL7V22Field RequestedDispenseCode
{
    get
    {
        if (_requestedDispenseCode != null)
        {
            return _requestedDispenseCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.10",
            Type = @"Field",
            Position = @"RXO.10",
            Name = @"Requested Dispense Code",
            Length = 100,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"what is to be/was dispensed; it is equivalent to OBR-4-universal service ID in function.  It may be present in the order or not, depending on the application.  If not present, and values are given for RXO-11requested dispense amount and RXO-12-requested dispense units, the RXO-1-requested give code is assumed.  If the requested dispense code does not include the dosage form, use RXO-5-requested dosage form. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.10.1",
                            Type = @"Component",
                            Position = @"RXO.10.1",
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
                            Id = @"RXO.10.2",
                            Type = @"Component",
                            Position = @"RXO.10.2",
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
                            Id = @"RXO.10.3",
                            Type = @"Component",
                            Position = @"RXO.10.3",
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
                            Id = @"RXO.10.4",
                            Type = @"Component",
                            Position = @"RXO.10.4",
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
                            Id = @"RXO.10.5",
                            Type = @"Component",
                            Position = @"RXO.10.5",
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
                            Id = @"RXO.10.6",
                            Type = @"Component",
                            Position = @"RXO.10.6",
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
                        },
                        }
        }

        _requestedDispenseCode = new HL7V22Field
        {
            field = message[@"RXO"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDispenseCode.field.FieldRepetitions != null && _requestedDispenseCode.field.FieldRepetitions.Count > 0)
        {
            _requestedDispenseCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requestedDispenseCode, fieldData);
        }

        return _requestedDispenseCode;
    } 
}

internal HL7V22Field _requestedDispenseAmount;

public HL7V22Field RequestedDispenseAmount
{
    get
    {
        if (_requestedDispenseAmount != null)
        {
            return _requestedDispenseAmount;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.11",
            Type = @"Field",
            Position = @"RXO.11",
            Name = @"Requested Dispense Amount",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount to be dispensed",
            Sample = @"",
            Fields = null
        }

        _requestedDispenseAmount = new HL7V22Field
        {
            field = message[@"RXO"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDispenseAmount.field.FieldRepetitions != null && _requestedDispenseAmount.field.FieldRepetitions.Count > 0)
        {
            _requestedDispenseAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requestedDispenseAmount, fieldData);
        }

        return _requestedDispenseAmount;
    } 
}

internal HL7V22Field _requestedDispenseUnits;

public HL7V22Field RequestedDispenseUnits
{
    get
    {
        if (_requestedDispenseUnits != null)
        {
            return _requestedDispenseUnits;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.12",
            Type = @"Field",
            Position = @"RXO.12",
            Name = @"Requested Dispense Units",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"units for the dispense amount.  This must be in simple units that reflect the actual quantity of the substance to be dispensed.  It does not include compound units",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.12.1",
                            Type = @"Component",
                            Position = @"RXO.12.1",
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
                            Id = @"RXO.12.2",
                            Type = @"Component",
                            Position = @"RXO.12.2",
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
                            Id = @"RXO.12.3",
                            Type = @"Component",
                            Position = @"RXO.12.3",
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
                            Id = @"RXO.12.4",
                            Type = @"Component",
                            Position = @"RXO.12.4",
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
                            Id = @"RXO.12.5",
                            Type = @"Component",
                            Position = @"RXO.12.5",
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
                            Id = @"RXO.12.6",
                            Type = @"Component",
                            Position = @"RXO.12.6",
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
                        },
                        }
        }

        _requestedDispenseUnits = new HL7V22Field
        {
            field = message[@"RXO"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDispenseUnits.field.FieldRepetitions != null && _requestedDispenseUnits.field.FieldRepetitions.Count > 0)
        {
            _requestedDispenseUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requestedDispenseUnits, fieldData);
        }

        return _requestedDispenseUnits;
    } 
}

internal HL7V22Field _numberOfRefills;

public HL7V22Field NumberOfRefills
{
    get
    {
        if (_numberOfRefills != null)
        {
            return _numberOfRefills;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.13",
            Type = @"Field",
            Position = @"RXO.13",
            Name = @"Number Of Refills",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"outpatient only",
            Sample = @"",
            Fields = null
        }

        _numberOfRefills = new HL7V22Field
        {
            field = message[@"RXO"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfRefills.field.FieldRepetitions != null && _numberOfRefills.field.FieldRepetitions.Count > 0)
        {
            _numberOfRefills.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_numberOfRefills, fieldData);
        }

        return _numberOfRefills;
    } 
}

internal HL7V22Field _orderingProvidersDeaNumber;

public HL7V22Field OrderingProvidersDeaNumber
{
    get
    {
        if (_orderingProvidersDeaNumber != null)
        {
            return _orderingProvidersDeaNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.14",
            Type = @"Field",
            Position = @"RXO.14",
            Name = @"Ordering Provider's Dea Number",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"if required by site.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.14.1",
                            Type = @"Component",
                            Position = @"RXO.14.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.2",
                            Type = @"Component",
                            Position = @"RXO.14.2",
                            Name = @"Familiy Name",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.3",
                            Type = @"Component",
                            Position = @"RXO.14.3",
                            Name = @"Given Name",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.4",
                            Type = @"Component",
                            Position = @"RXO.14.4",
                            Name = @"Middle Initial Or Name",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.5",
                            Type = @"Component",
                            Position = @"RXO.14.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.6",
                            Type = @"Component",
                            Position = @"RXO.14.6",
                            Name = @"Prefix (e.g. Dr)",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.7",
                            Type = @"Component",
                            Position = @"RXO.14.7",
                            Name = @"Degree (e.g. Md)",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.8",
                            Type = @"Component",
                            Position = @"RXO.14.8",
                            Name = @"Source Table Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _orderingProvidersDeaNumber = new HL7V22Field
        {
            field = message[@"RXO"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderingProvidersDeaNumber.field.FieldRepetitions != null && _orderingProvidersDeaNumber.field.FieldRepetitions.Count > 0)
        {
            _orderingProvidersDeaNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_orderingProvidersDeaNumber, fieldData);
        }

        return _orderingProvidersDeaNumber;
    } 
}

internal HL7V22Field _pharmacistVerifierId;

public HL7V22Field PharmacistVerifierId
{
    get
    {
        if (_pharmacistVerifierId != null)
        {
            return _pharmacistVerifierId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.15",
            Type = @"Field",
            Position = @"RXO.15",
            Name = @"Pharmacist Verifier Id",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"provider ID of pharmacist verifier.  Use if required by the Pharmacy application or site on orders (or some subgroup of orders), in addition to ORC-11-verified by",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.15.1",
                            Type = @"Component",
                            Position = @"RXO.15.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.2",
                            Type = @"Component",
                            Position = @"RXO.15.2",
                            Name = @"Familiy Name",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.3",
                            Type = @"Component",
                            Position = @"RXO.15.3",
                            Name = @"Given Name",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.4",
                            Type = @"Component",
                            Position = @"RXO.15.4",
                            Name = @"Middle Initial Or Name",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.5",
                            Type = @"Component",
                            Position = @"RXO.15.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.6",
                            Type = @"Component",
                            Position = @"RXO.15.6",
                            Name = @"Prefix (e.g. Dr)",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.7",
                            Type = @"Component",
                            Position = @"RXO.15.7",
                            Name = @"Degree (e.g. Md)",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.8",
                            Type = @"Component",
                            Position = @"RXO.15.8",
                            Name = @"Source Table Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _pharmacistVerifierId = new HL7V22Field
        {
            field = message[@"RXO"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pharmacistVerifierId.field.FieldRepetitions != null && _pharmacistVerifierId.field.FieldRepetitions.Count > 0)
        {
            _pharmacistVerifierId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_pharmacistVerifierId, fieldData);
        }

        return _pharmacistVerifierId;
    } 
}

internal HL7V22Field _needsHumanReview;

public HL7V22Field NeedsHumanReview
{
    get
    {
        if (_needsHumanReview != null)
        {
            return _needsHumanReview;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.16",
            Type = @"Field",
            Position = @"RXO.16",
            Name = @"Needs Human Review",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"uses table 0136 - Y/N indicator.

A smart Order Entry application knows of a possible drug interaction on a certain order, but the provider issuing the order wants to override the condition.  In this case, the Pharmacy application receiving the order will want to have a staff pharmacist review the interaction and contact the ordering physician",
            Sample = @"",
            Fields = null
        }

        _needsHumanReview = new HL7V22Field
        {
            field = message[@"RXO"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_needsHumanReview.field.FieldRepetitions != null && _needsHumanReview.field.FieldRepetitions.Count > 0)
        {
            _needsHumanReview.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_needsHumanReview, fieldData);
        }

        return _needsHumanReview;
    } 
}

internal HL7V22Field _requestedGivePertimeUnit;

public HL7V22Field RequestedGivePertimeUnit
{
    get
    {
        if (_requestedGivePertimeUnit != null)
        {
            return _requestedGivePertimeUnit;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXO.17",
            Type = @"Field",
            Position = @"RXO.17",
            Name = @"Requested Give Per (time Unit)",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"time unit to use to calculate the rate at which the pharmaceutical is to be administered",
            Sample = @"",
            Fields = null
        }

        _requestedGivePertimeUnit = new HL7V22Field
        {
            field = message[@"RXO"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGivePertimeUnit.field.FieldRepetitions != null && _requestedGivePertimeUnit.field.FieldRepetitions.Count > 0)
        {
            _requestedGivePertimeUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_requestedGivePertimeUnit, fieldData);
        }

        return _requestedGivePertimeUnit;
    } 
}
    }
}
