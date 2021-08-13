using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentNK1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NK1"; } }

        public string SegmentId { get { return @"NK1"; } }
        
        public string LongName { get { return @"Next Of Kin"; } }
        
        public string Description { get { return @"The NK1 segment contains information about the patient's other related parties. Any associated parties may be identified. Utilizing NK1-1-set ID, multiple NK1 segments can be sent to patient accounts"; } }
        
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

        public HL7V22SegmentNK1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdNextOfKin;

public HL7V22Field SetIdNextOfKin
{
    get
    {
        if (_setIdNextOfKin != null)
        {
            return _setIdNextOfKin;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.1",
            Type = @"Field",
            Position = @"NK1.1",
            Name = @"Set Id - Next Of Kin",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies the NK1 records for the purpose of adding, changing, or deleting records.  For those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.  For example, the swap and query transactions allow for multiple PID segments would have Set ID values of 1, 2, then 3, etc. ",
            Sample = @"",
            Fields = null
        }

        _setIdNextOfKin = new HL7V22Field
        {
            field = message[@"NK1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdNextOfKin.field.FieldRepetitions != null && _setIdNextOfKin.field.FieldRepetitions.Count > 0)
        {
            _setIdNextOfKin.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdNextOfKin, fieldData);
        }

        return _setIdNextOfKin;
    } 
}

internal HL7V22Field _name;

public HL7V22Field Name
{
    get
    {
        if (_name != null)
        {
            return _name;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.2",
            Type = @"Field",
            Position = @"NK1.2",
            Name = @"Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the next of kin",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.2.1",
                            Type = @"Component",
                            Position = @"NK1.2.1",
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
                            Id = @"NK1.2.2",
                            Type = @"Component",
                            Position = @"NK1.2.2",
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
                            Id = @"NK1.2.3",
                            Type = @"Component",
                            Position = @"NK1.2.3",
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
                            Id = @"NK1.2.4",
                            Type = @"Component",
                            Position = @"NK1.2.4",
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
                            Id = @"NK1.2.5",
                            Type = @"Component",
                            Position = @"NK1.2.5",
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
                            Id = @"NK1.2.6",
                            Type = @"Component",
                            Position = @"NK1.2.6",
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
                        }
        }

        _name = new HL7V22Field
        {
            field = message[@"NK1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_name.field.FieldRepetitions != null && _name.field.FieldRepetitions.Count > 0)
        {
            _name.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_name, fieldData);
        }

        return _name;
    } 
}

internal HL7V22Field _relationship;

public HL7V22Field Relationship
{
    get
    {
        if (_relationship != null)
        {
            return _relationship;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.3",
            Type = @"Field",
            Position = @"NK1.3",
            Name = @"Relationship",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0063",
            TableName = @"RELATIONSHIP",
            Description = @"defines the actual personal relationship that the next of kin has to the patient.  Refer to user-defined table 0063 - relationship.  Examples might include: brother, sister, mother, father, friend, spouse, emergency contact, employer, etc",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.3.1",
                            Type = @"Component",
                            Position = @"NK1.3.1",
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
                            Id = @"NK1.3.2",
                            Type = @"Component",
                            Position = @"NK1.3.2",
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
                            Id = @"NK1.3.3",
                            Type = @"Component",
                            Position = @"NK1.3.3",
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
                            Id = @"NK1.3.4",
                            Type = @"Component",
                            Position = @"NK1.3.4",
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
                            Id = @"NK1.3.5",
                            Type = @"Component",
                            Position = @"NK1.3.5",
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
                            Id = @"NK1.3.6",
                            Type = @"Component",
                            Position = @"NK1.3.6",
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

        _relationship = new HL7V22Field
        {
            field = message[@"NK1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relationship.field.FieldRepetitions != null && _relationship.field.FieldRepetitions.Count > 0)
        {
            _relationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_relationship, fieldData);
        }

        return _relationship;
    } 
}

internal HL7V22Field _address;

public HL7V22Field Address
{
    get
    {
        if (_address != null)
        {
            return _address;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.4",
            Type = @"Field",
            Position = @"NK1.4",
            Name = @"Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @"defines the address of the associated party",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.4.1",
                            Type = @"Component",
                            Position = @"NK1.4.1",
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
                            Id = @"NK1.4.2",
                            Type = @"Component",
                            Position = @"NK1.4.2",
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
                            Id = @"NK1.4.3",
                            Type = @"Component",
                            Position = @"NK1.4.3",
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
                            Id = @"NK1.4.4",
                            Type = @"Component",
                            Position = @"NK1.4.4",
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
                            Id = @"NK1.4.5",
                            Type = @"Component",
                            Position = @"NK1.4.5",
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
                            Id = @"NK1.4.6",
                            Type = @"Component",
                            Position = @"NK1.4.6",
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
                            Id = @"NK1.4.7",
                            Type = @"Component",
                            Position = @"NK1.4.7",
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
                            Id = @"NK1.4.8",
                            Type = @"Component",
                            Position = @"NK1.4.8",
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
                        },
                        }
        }

        _address = new HL7V22Field
        {
            field = message[@"NK1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_address.field.FieldRepetitions != null && _address.field.FieldRepetitions.Count > 0)
        {
            _address.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_address, fieldData);
        }

        return _address;
    } 
}

internal HL7V22Field _phoneNumber;

public HL7V22Field PhoneNumber
{
    get
    {
        if (_phoneNumber != null)
        {
            return _phoneNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.5",
            Type = @"Field",
            Position = @"NK1.5",
            Name = @"Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"defines the telephone number of the associated party",
            Sample = @"",
            Fields = null
        }

        _phoneNumber = new HL7V22Field
        {
            field = message[@"NK1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phoneNumber.field.FieldRepetitions != null && _phoneNumber.field.FieldRepetitions.Count > 0)
        {
            _phoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_phoneNumber, fieldData);
        }

        return _phoneNumber;
    } 
}

internal HL7V22Field _businessPhoneNumber;

public HL7V22Field BusinessPhoneNumber
{
    get
    {
        if (_businessPhoneNumber != null)
        {
            return _businessPhoneNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.6",
            Type = @"Field",
            Position = @"NK1.6",
            Name = @"Business Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"defines the business telephone number of the associated party",
            Sample = @"",
            Fields = null
        }

        _businessPhoneNumber = new HL7V22Field
        {
            field = message[@"NK1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_businessPhoneNumber.field.FieldRepetitions != null && _businessPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _businessPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_businessPhoneNumber, fieldData);
        }

        return _businessPhoneNumber;
    } 
}

internal HL7V22Field _contactRole;

public HL7V22Field ContactRole
{
    get
    {
        if (_contactRole != null)
        {
            return _contactRole;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.7",
            Type = @"Field",
            Position = @"NK1.7",
            Name = @"Contact Role",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0131",
            TableName = @"CONTRACT ROLE",
            Description = @"indicates the specific relationship role (next of kin, employer, emergency contact, etc.).  Refer to userdefined table 0131 - contact role.  This field specifies the role that the next of kin plays with regards to the patient.  For example, an employer, emergency contact, next of kin, insurance company, state agency, federal agency etc.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.7.1",
                            Type = @"Component",
                            Position = @"NK1.7.1",
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
                            Id = @"NK1.7.2",
                            Type = @"Component",
                            Position = @"NK1.7.2",
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
                            Id = @"NK1.7.3",
                            Type = @"Component",
                            Position = @"NK1.7.3",
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
                            Id = @"NK1.7.4",
                            Type = @"Component",
                            Position = @"NK1.7.4",
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
                            Id = @"NK1.7.5",
                            Type = @"Component",
                            Position = @"NK1.7.5",
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
                            Id = @"NK1.7.6",
                            Type = @"Component",
                            Position = @"NK1.7.6",
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

        _contactRole = new HL7V22Field
        {
            field = message[@"NK1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactRole.field.FieldRepetitions != null && _contactRole.field.FieldRepetitions.Count > 0)
        {
            _contactRole.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_contactRole, fieldData);
        }

        return _contactRole;
    } 
}

internal HL7V22Field _startDate;

public HL7V22Field StartDate
{
    get
    {
        if (_startDate != null)
        {
            return _startDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.8",
            Type = @"Field",
            Position = @"NK1.8",
            Name = @"Start Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"start of relationship",
            Sample = @"",
            Fields = null
        }

        _startDate = new HL7V22Field
        {
            field = message[@"NK1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startDate.field.FieldRepetitions != null && _startDate.field.FieldRepetitions.Count > 0)
        {
            _startDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_startDate, fieldData);
        }

        return _startDate;
    } 
}

internal HL7V22Field _endDate;

public HL7V22Field EndDate
{
    get
    {
        if (_endDate != null)
        {
            return _endDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.9",
            Type = @"Field",
            Position = @"NK1.9",
            Name = @"End Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"end of relationship",
            Sample = @"",
            Fields = null
        }

        _endDate = new HL7V22Field
        {
            field = message[@"NK1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endDate.field.FieldRepetitions != null && _endDate.field.FieldRepetitions.Count > 0)
        {
            _endDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_endDate, fieldData);
        }

        return _endDate;
    } 
}

internal HL7V22Field _nextOfKin;

public HL7V22Field NextOfKin
{
    get
    {
        if (_nextOfKin != null)
        {
            return _nextOfKin;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.10",
            Type = @"Field",
            Position = @"NK1.10",
            Name = @"Next Of Kin",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"title of the next of kin at their place of employment",
            Sample = @"",
            Fields = null
        }

        _nextOfKin = new HL7V22Field
        {
            field = message[@"NK1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextOfKin.field.FieldRepetitions != null && _nextOfKin.field.FieldRepetitions.Count > 0)
        {
            _nextOfKin.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_nextOfKin, fieldData);
        }

        return _nextOfKin;
    } 
}

internal HL7V22Field _nextOfKinJobCodeClass;

public HL7V22Field NextOfKinJobCodeClass
{
    get
    {
        if (_nextOfKinJobCodeClass != null)
        {
            return _nextOfKinJobCodeClass;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.11",
            Type = @"Field",
            Position = @"NK1.11",
            Name = @"Next Of Kin Job Code / Class",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_JOB_CODE",
            DataTypeName = @"Job Title",
            TableId = null,
            TableName = null,
            Description = @"the employers Job Code or Employee Classification used for the next of kin at their place of employment",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.11.1",
                            Type = @"Component",
                            Position = @"NK1.11.1",
                            Name = @"Job Code",
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
                            Id = @"NK1.11.2",
                            Type = @"Component",
                            Position = @"NK1.11.2",
                            Name = @"Employee Classification",
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

        _nextOfKinJobCodeClass = new HL7V22Field
        {
            field = message[@"NK1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextOfKinJobCodeClass.field.FieldRepetitions != null && _nextOfKinJobCodeClass.field.FieldRepetitions.Count > 0)
        {
            _nextOfKinJobCodeClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_nextOfKinJobCodeClass, fieldData);
        }

        return _nextOfKinJobCodeClass;
    } 
}

internal HL7V22Field _nextOfKinEmployeeNumber;

public HL7V22Field NextOfKinEmployeeNumber
{
    get
    {
        if (_nextOfKinEmployeeNumber != null)
        {
            return _nextOfKinEmployeeNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.12",
            Type = @"Field",
            Position = @"NK1.12",
            Name = @"Next Of Kin Employee Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"number the employer assigns to the employee that is acting as next of kin",
            Sample = @"",
            Fields = null
        }

        _nextOfKinEmployeeNumber = new HL7V22Field
        {
            field = message[@"NK1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextOfKinEmployeeNumber.field.FieldRepetitions != null && _nextOfKinEmployeeNumber.field.FieldRepetitions.Count > 0)
        {
            _nextOfKinEmployeeNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_nextOfKinEmployeeNumber, fieldData);
        }

        return _nextOfKinEmployeeNumber;
    } 
}

internal HL7V22Field _organizationName;

public HL7V22Field OrganizationName
{
    get
    {
        if (_organizationName != null)
        {
            return _organizationName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NK1.13",
            Type = @"Field",
            Position = @"NK1.13",
            Name = @"Organization Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"in cases where an employer serves as next of kin, this is the name of the organization which serves as the next of kin.  This field may also be used to communicate the name of the organization where the next of kin works.",
            Sample = @"",
            Fields = null
        }

        _organizationName = new HL7V22Field
        {
            field = message[@"NK1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_organizationName.field.FieldRepetitions != null && _organizationName.field.FieldRepetitions.Count > 0)
        {
            _organizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_organizationName, fieldData);
        }

        return _organizationName;
    } 
}
    }
}
