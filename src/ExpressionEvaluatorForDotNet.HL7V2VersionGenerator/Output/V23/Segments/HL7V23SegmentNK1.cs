using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentNK1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NK1"; } }

        public string SegmentId { get { return @"NK1"; } }
        
        public string LongName { get { return @"Next of kin"; } }
        
        public string Description { get { return @"The NK1 segment contains information about the patient’s other related parties.  Any associated parties may be identified.  Utilizing NK1-1-set ID, multiple NK1 segments can be sent to patient accounts"; } }
        
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

        public HL7V23SegmentNK1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDNextofKin;

public HL7V23Field SetIDNextofKin
{
    get
    {
        if (_setIDNextofKin != null)
        {
            return _setIDNextofKin;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.1",
            Type = @"Field",
            Position = @"NK1.1",
            Name = @"Set ID - Next of Kin",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc",
            Sample = @"",
            Fields = null
        }

        _setIDNextofKin = new HL7V23Field
        {
            field = message[@"NK1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDNextofKin.field.FieldRepetitions != null && _setIDNextofKin.field.FieldRepetitions.Count > 0)
        {
            _setIDNextofKin.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDNextofKin, fieldData);
        }

        return _setIDNextofKin;
    } 
}

internal HL7V23Field _nKName;

public HL7V23Field NKName
{
    get
    {
        if (_nKName != null)
        {
            return _nKName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.2",
            Type = @"Field",
            Position = @"NK1.2",
            Name = @"NK Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the next of kin or associated party.  Multiple names for the same person are allowed, but the legal name must be sent in the first sequence.  If the legal name is not sent, then the repeat delimiter must be sent in the first sequence.  Refer to Chapter 2 for the name type code table",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.2.1",
                            Type = @"Component",
                            Position = @"NK1.2.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
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
                            TableId = @"FirstName",
                            TableName = @"First Name",
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
                            Name = @"Suffix",
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
                            Name = @"Prefix",
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
                            Name = @"Degree",
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
                            Id = @"NK1.2.7",
                            Type = @"Component",
                            Position = @"NK1.2.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.2.8",
                            Type = @"Component",
                            Position = @"NK1.2.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _nKName = new HL7V23Field
        {
            field = message[@"NK1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nKName.field.FieldRepetitions != null && _nKName.field.FieldRepetitions.Count > 0)
        {
            _nKName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nKName, fieldData);
        }

        return _nKName;
    } 
}

internal HL7V23Field _relationship;

public HL7V23Field Relationship
{
    get
    {
        if (_relationship != null)
        {
            return _relationship;
        }

        var fieldData = new HL7V23FieldData
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
            TableName = @"Relationship",
            Description = @"This field contains the actual personal relationship that the next of kin/associated parties has to the patient.  Refer to user-defined table 0063 - Relationship for suggested values.  Examples might include: brother, sister, mother, father, friend, spouse, emergency contact, employer, etc.",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _relationship = new HL7V23Field
        {
            field = message[@"NK1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relationship.field.FieldRepetitions != null && _relationship.field.FieldRepetitions.Count > 0)
        {
            _relationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_relationship, fieldData);
        }

        return _relationship;
    } 
}

internal HL7V23Field _address;

public HL7V23Field Address
{
    get
    {
        if (_address != null)
        {
            return _address;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.4",
            Type = @"Field",
            Position = @"NK1.4",
            Name = @"Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the next of kin/associated party.  Multiple addresses are allowed for the same person.  The mailing address must be sent in the first sequence.  If the mailing address is not sent, then the repeat delimiter must be sent in the first sequence",
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
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution",
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
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
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
                            TableId = @"City",
                            TableName = @"City",
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
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"tate or province should be represented by the official postal service codes for that country",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.7",
                            Type = @"Component",
                            Position = @"NK1.4.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
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
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.9",
                            Type = @"Component",
                            Position = @"NK1.4.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.4.10",
                            Type = @"Component",
                            Position = @"NK1.4.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _address = new HL7V23Field
        {
            field = message[@"NK1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_address.field.FieldRepetitions != null && _address.field.FieldRepetitions.Count > 0)
        {
            _address.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_address, fieldData);
        }

        return _address;
    } 
}

internal HL7V23Field _phoneNumber;

public HL7V23Field PhoneNumber
{
    get
    {
        if (_phoneNumber != null)
        {
            return _phoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.5",
            Type = @"Field",
            Position = @"NK1.5",
            Name = @"Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number of the next of kin/associated party.  Multiple phone numbers are allowed for the same person.  The primary telephone number must be sent in the first sequence.  If the primary telephone number is not sent, then the repeat delimiter must be sent in the first sequence.  Refer to Chapter 2 for suggested telecommunication use and equipment type codes",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.5.1",
                            Type = @"Component",
                            Position = @"NK1.5.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.5.2",
                            Type = @"Component",
                            Position = @"NK1.5.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.5.3",
                            Type = @"Component",
                            Position = @"NK1.5.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.5.4",
                            Type = @"Component",
                            Position = @"NK1.5.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.5.5",
                            Type = @"Component",
                            Position = @"NK1.5.5",
                            Name = @"Country Code",
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
                            Id = @"NK1.5.6",
                            Type = @"Component",
                            Position = @"NK1.5.6",
                            Name = @"Area/city Code",
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
                            Id = @"NK1.5.7",
                            Type = @"Component",
                            Position = @"NK1.5.7",
                            Name = @"Phone Number",
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
                            Id = @"NK1.5.8",
                            Type = @"Component",
                            Position = @"NK1.5.8",
                            Name = @"Extension",
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
                            Id = @"NK1.5.9",
                            Type = @"Component",
                            Position = @"NK1.5.9",
                            Name = @"Any Text",
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

        _phoneNumber = new HL7V23Field
        {
            field = message[@"NK1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phoneNumber.field.FieldRepetitions != null && _phoneNumber.field.FieldRepetitions.Count > 0)
        {
            _phoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_phoneNumber, fieldData);
        }

        return _phoneNumber;
    } 
}

internal HL7V23Field _businessPhoneNumber;

public HL7V23Field BusinessPhoneNumber
{
    get
    {
        if (_businessPhoneNumber != null)
        {
            return _businessPhoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.6",
            Type = @"Field",
            Position = @"NK1.6",
            Name = @"Business Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the business telephone number of the next of kin/associated party.  Multiple phone numbers are allowed for the same person.  The primary business telephone number must be sent in the first sequence.  If the primary business telephone number is not sent, then the repeat delimiter must be sent in the first sequence.  Refer to Chapter 2 for suggested telecommunication use and equipment type codes",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.6.1",
                            Type = @"Component",
                            Position = @"NK1.6.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.6.2",
                            Type = @"Component",
                            Position = @"NK1.6.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.6.3",
                            Type = @"Component",
                            Position = @"NK1.6.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.6.4",
                            Type = @"Component",
                            Position = @"NK1.6.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.6.5",
                            Type = @"Component",
                            Position = @"NK1.6.5",
                            Name = @"Country Code",
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
                            Id = @"NK1.6.6",
                            Type = @"Component",
                            Position = @"NK1.6.6",
                            Name = @"Area/city Code",
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
                            Id = @"NK1.6.7",
                            Type = @"Component",
                            Position = @"NK1.6.7",
                            Name = @"Phone Number",
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
                            Id = @"NK1.6.8",
                            Type = @"Component",
                            Position = @"NK1.6.8",
                            Name = @"Extension",
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
                            Id = @"NK1.6.9",
                            Type = @"Component",
                            Position = @"NK1.6.9",
                            Name = @"Any Text",
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

        _businessPhoneNumber = new HL7V23Field
        {
            field = message[@"NK1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_businessPhoneNumber.field.FieldRepetitions != null && _businessPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _businessPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_businessPhoneNumber, fieldData);
        }

        return _businessPhoneNumber;
    } 
}

internal HL7V23Field _contactRole;

public HL7V23Field ContactRole
{
    get
    {
        if (_contactRole != null)
        {
            return _contactRole;
        }

        var fieldData = new HL7V23FieldData
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
            TableName = @"Contact role",
            Description = @"This field indicates the specific relationship role (next of kin, employer, emergency contact, etc.).  Refer to user-defined table 0131 - Contact role for suggested values.  This field specifies the role that the next of kin/associated parties plays with regard to the patient.  Examples might include an employer, emergency contact, next of kin, insurance company, state agency, federal agency, etc",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _contactRole = new HL7V23Field
        {
            field = message[@"NK1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactRole.field.FieldRepetitions != null && _contactRole.field.FieldRepetitions.Count > 0)
        {
            _contactRole.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactRole, fieldData);
        }

        return _contactRole;
    } 
}

internal HL7V23Field _startDate;

public HL7V23Field StartDate
{
    get
    {
        if (_startDate != null)
        {
            return _startDate;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the start of the contact role. ",
            Sample = @"",
            Fields = null
        }

        _startDate = new HL7V23Field
        {
            field = message[@"NK1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startDate.field.FieldRepetitions != null && _startDate.field.FieldRepetitions.Count > 0)
        {
            _startDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_startDate, fieldData);
        }

        return _startDate;
    } 
}

internal HL7V23Field _endDate;

public HL7V23Field EndDate
{
    get
    {
        if (_endDate != null)
        {
            return _endDate;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the end of the contact role",
            Sample = @"",
            Fields = null
        }

        _endDate = new HL7V23Field
        {
            field = message[@"NK1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endDate.field.FieldRepetitions != null && _endDate.field.FieldRepetitions.Count > 0)
        {
            _endDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_endDate, fieldData);
        }

        return _endDate;
    } 
}

internal HL7V23Field _nextofKinAssociatedPartiesJobTitle;

public HL7V23Field NextofKinAssociatedPartiesJobTitle
{
    get
    {
        if (_nextofKinAssociatedPartiesJobTitle != null)
        {
            return _nextofKinAssociatedPartiesJobTitle;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.10",
            Type = @"Field",
            Position = @"NK1.10",
            Name = @"Next of Kin/Associated Parties Job Title",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the title of the next of kin/associated parties at their place of employment.  However, if the contact role is the patient’s employer, this field contains the title of the patient at their place of employment",
            Sample = @"",
            Fields = null
        }

        _nextofKinAssociatedPartiesJobTitle = new HL7V23Field
        {
            field = message[@"NK1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextofKinAssociatedPartiesJobTitle.field.FieldRepetitions != null && _nextofKinAssociatedPartiesJobTitle.field.FieldRepetitions.Count > 0)
        {
            _nextofKinAssociatedPartiesJobTitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nextofKinAssociatedPartiesJobTitle, fieldData);
        }

        return _nextofKinAssociatedPartiesJobTitle;
    } 
}

internal HL7V23Field _nextofKinJobAssociatedPartiesCodeClass;

public HL7V23Field NextofKinJobAssociatedPartiesCodeClass
{
    get
    {
        if (_nextofKinJobAssociatedPartiesCodeClass != null)
        {
            return _nextofKinJobAssociatedPartiesCodeClass;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.11",
            Type = @"Field",
            Position = @"NK1.11",
            Name = @"Next of Kin Job/Associated Parties Code/Class",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"JCC",
            DataTypeName = @"Job Code Class",
            TableId = null,
            TableName = null,
            Description = @"This field contains the employer’s job code and the employee classification used for the next of kin/associated parties at their place of employment. However, if the contact role is the patient’s employer, this field contains the job code/class of the patient at their place of employment.  Refer to user-defined tables 0327 - Job code and 0328 - Employee classification for suggested values",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0327",
                            TableName = @"Job code",
                            Description = @"This component contains the person’s  job code.  Refer to user-defined table 0327 - job code",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.11.2",
                            Type = @"Component",
                            Position = @"NK1.11.2",
                            Name = @"Job Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0328",
                            TableName = @"Employee classification",
                            Description = @"This component contains the person’s employee classification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _nextofKinJobAssociatedPartiesCodeClass = new HL7V23Field
        {
            field = message[@"NK1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextofKinJobAssociatedPartiesCodeClass.field.FieldRepetitions != null && _nextofKinJobAssociatedPartiesCodeClass.field.FieldRepetitions.Count > 0)
        {
            _nextofKinJobAssociatedPartiesCodeClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nextofKinJobAssociatedPartiesCodeClass, fieldData);
        }

        return _nextofKinJobAssociatedPartiesCodeClass;
    } 
}

internal HL7V23Field _nextofKinAssociatedPartiesEmployeeNumber;

public HL7V23Field NextofKinAssociatedPartiesEmployeeNumber
{
    get
    {
        if (_nextofKinAssociatedPartiesEmployeeNumber != null)
        {
            return _nextofKinAssociatedPartiesEmployeeNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.12",
            Type = @"Field",
            Position = @"NK1.12",
            Name = @"Next of Kin/Associated Parties Employee Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"For backward compatibility, the ST data type can be sent; however HL7 recommends that the CX data type be used for new implementations.  This field contains the number that the employer assigns to the employee that is acting as next of kin/associated parties. However, if the contact role is the patient’s employer, this field contains the employee number of the patient at their place of employment",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.12.1",
                            Type = @"Component",
                            Position = @"NK1.12.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.12.2",
                            Type = @"Component",
                            Position = @"NK1.12.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.12.3",
                            Type = @"Component",
                            Position = @"NK1.12.3",
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
                            Id = @"NK1.12.4",
                            Type = @"Component",
                            Position = @"NK1.12.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NK1.12.4.1",
                            Type = @"SubComponent",
                            Position = @"NK1.12.4.1",
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
                            Id = @"NK1.12.4.2",
                            Type = @"SubComponent",
                            Position = @"NK1.12.4.2",
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
                            Id = @"NK1.12.4.3",
                            Type = @"SubComponent",
                            Position = @"NK1.12.4.3",
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
                            Id = @"NK1.12.5",
                            Type = @"Component",
                            Position = @"NK1.12.5",
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
                            Id = @"NK1.12.6",
                            Type = @"Component",
                            Position = @"NK1.12.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NK1.12.6.1",
                            Type = @"SubComponent",
                            Position = @"NK1.12.6.1",
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
                            Id = @"NK1.12.6.2",
                            Type = @"SubComponent",
                            Position = @"NK1.12.6.2",
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
                            Id = @"NK1.12.6.3",
                            Type = @"SubComponent",
                            Position = @"NK1.12.6.3",
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

        _nextofKinAssociatedPartiesEmployeeNumber = new HL7V23Field
        {
            field = message[@"NK1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextofKinAssociatedPartiesEmployeeNumber.field.FieldRepetitions != null && _nextofKinAssociatedPartiesEmployeeNumber.field.FieldRepetitions.Count > 0)
        {
            _nextofKinAssociatedPartiesEmployeeNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nextofKinAssociatedPartiesEmployeeNumber, fieldData);
        }

        return _nextofKinAssociatedPartiesEmployeeNumber;
    } 
}

internal HL7V23Field _organizationName;

public HL7V23Field OrganizationName
{
    get
    {
        if (_organizationName != null)
        {
            return _organizationName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.13",
            Type = @"Field",
            Position = @"NK1.13",
            Name = @"Organization Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the organization that serves as a next of kin/associated party or as the next of kin of the patient.  This field may also be used to communicate the name of the organization at which the associated party works.  Multiple names for the same organization may be sent.  If multiple names are sent, the legal name must be sent in the first sequence.  If the legal name is not sent, then a repeat delimiter must be sent in the first sequence",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.13.1",
                            Type = @"Component",
                            Position = @"NK1.13.1",
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
                            Id = @"NK1.13.2",
                            Type = @"Component",
                            Position = @"NK1.13.2",
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
                            Id = @"NK1.13.3",
                            Type = @"Component",
                            Position = @"NK1.13.3",
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
                            Id = @"NK1.13.4",
                            Type = @"Component",
                            Position = @"NK1.13.4",
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
                            Id = @"NK1.13.5",
                            Type = @"Component",
                            Position = @"NK1.13.5",
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
                            Id = @"NK1.13.6",
                            Type = @"Component",
                            Position = @"NK1.13.6",
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
                            Id = @"NK1.13.6.1",
                            Type = @"SubComponent",
                            Position = @"NK1.13.6.1",
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
                            Id = @"NK1.13.6.2",
                            Type = @"SubComponent",
                            Position = @"NK1.13.6.2",
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
                            Id = @"NK1.13.6.3",
                            Type = @"SubComponent",
                            Position = @"NK1.13.6.3",
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
                            Id = @"NK1.13.7",
                            Type = @"Component",
                            Position = @"NK1.13.7",
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
                            Id = @"NK1.13.8",
                            Type = @"Component",
                            Position = @"NK1.13.8",
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
                            Id = @"NK1.13.8.1",
                            Type = @"SubComponent",
                            Position = @"NK1.13.8.1",
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
                            Id = @"NK1.13.8.2",
                            Type = @"SubComponent",
                            Position = @"NK1.13.8.2",
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
                            Id = @"NK1.13.8.3",
                            Type = @"SubComponent",
                            Position = @"NK1.13.8.3",
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

        _organizationName = new HL7V23Field
        {
            field = message[@"NK1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_organizationName.field.FieldRepetitions != null && _organizationName.field.FieldRepetitions.Count > 0)
        {
            _organizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_organizationName, fieldData);
        }

        return _organizationName;
    } 
}

internal HL7V23Field _maritalStatus;

public HL7V23Field MaritalStatus
{
    get
    {
        if (_maritalStatus != null)
        {
            return _maritalStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.14",
            Type = @"Field",
            Position = @"NK1.14",
            Name = @"Marital Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0002",
            TableName = @"Marital status",
            Description = @"This field contains the next of kin/associated party’s marital status.  Refer to user-defined table 0002 - Marital status for suggested values",
            Sample = @"",
            Fields = null
        }

        _maritalStatus = new HL7V23Field
        {
            field = message[@"NK1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_maritalStatus.field.FieldRepetitions != null && _maritalStatus.field.FieldRepetitions.Count > 0)
        {
            _maritalStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_maritalStatus, fieldData);
        }

        return _maritalStatus;
    } 
}

internal HL7V23Field _sex;

public HL7V23Field Sex
{
    get
    {
        if (_sex != null)
        {
            return _sex;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.15",
            Type = @"Field",
            Position = @"NK1.15",
            Name = @"Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0001",
            TableName = @"Sex",
            Description = @"This field contains the next of kin/associated party’s sex.  Refer to user-defined table 0001 - Sex for suggested values",
            Sample = @"",
            Fields = null
        }

        _sex = new HL7V23Field
        {
            field = message[@"NK1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sex.field.FieldRepetitions != null && _sex.field.FieldRepetitions.Count > 0)
        {
            _sex.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_sex, fieldData);
        }

        return _sex;
    } 
}

internal HL7V23Field _dateofBirth;

public HL7V23Field DateofBirth
{
    get
    {
        if (_dateofBirth != null)
        {
            return _dateofBirth;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.16",
            Type = @"Field",
            Position = @"NK1.16",
            Name = @"Date of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the next of kin/associated party’s birth date and time",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.16.1",
                            Type = @"Component",
                            Position = @"NK1.16.1",
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

        _dateofBirth = new HL7V23Field
        {
            field = message[@"NK1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateofBirth.field.FieldRepetitions != null && _dateofBirth.field.FieldRepetitions.Count > 0)
        {
            _dateofBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dateofBirth, fieldData);
        }

        return _dateofBirth;
    } 
}

internal HL7V23Field _livingDependency;

public HL7V23Field LivingDependency
{
    get
    {
        if (_livingDependency != null)
        {
            return _livingDependency;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.17",
            Type = @"Field",
            Position = @"NK1.17",
            Name = @"Living Dependency",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0223",
            TableName = @"Living dependency",
            Description = @"This field identifies specific living conditions (e.g., spouse dependent on patient, walk-up) that are relevant to an evaluation of the patient’s healthcare needs.  This information can be used for discharge planning.  Examples might include Spouse Dependent, Medical Supervision Required, Small Children Dependent.  This field repeats because, for example, “spouse dependent” and “medical supervision required” can apply at the same time.  Refer to user-defined table 0223 - Living dependency for suggested values",
            Sample = @"",
            Fields = null
        }

        _livingDependency = new HL7V23Field
        {
            field = message[@"NK1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingDependency.field.FieldRepetitions != null && _livingDependency.field.FieldRepetitions.Count > 0)
        {
            _livingDependency.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_livingDependency, fieldData);
        }

        return _livingDependency;
    } 
}

internal HL7V23Field _ambulatoryStatus;

public HL7V23Field AmbulatoryStatus
{
    get
    {
        if (_ambulatoryStatus != null)
        {
            return _ambulatoryStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.18",
            Type = @"Field",
            Position = @"NK1.18",
            Name = @"Ambulatory Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0009",
            TableName = @"Ambulatory status",
            Description = @"This field identifies the transient rate of mobility for the next of kin/associated party.  Refer to user-defined table 0009 - Ambulatory status for suggested values",
            Sample = @"",
            Fields = null
        }

        _ambulatoryStatus = new HL7V23Field
        {
            field = message[@"NK1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ambulatoryStatus.field.FieldRepetitions != null && _ambulatoryStatus.field.FieldRepetitions.Count > 0)
        {
            _ambulatoryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_ambulatoryStatus, fieldData);
        }

        return _ambulatoryStatus;
    } 
}

internal HL7V23Field _citizenship;

public HL7V23Field Citizenship
{
    get
    {
        if (_citizenship != null)
        {
            return _citizenship;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.19",
            Type = @"Field",
            Position = @"NK1.19",
            Name = @"Citizenship",
            Length = 4,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0171",
            TableName = @"Citizenship",
            Description = @"This field contains the code to identify the next of kin/associated party’s citizenship.  HL7 recommends using ISO 3166 as the suggested values in user-defined table 0171 - Country code",
            Sample = @"",
            Fields = null
        }

        _citizenship = new HL7V23Field
        {
            field = message[@"NK1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_citizenship.field.FieldRepetitions != null && _citizenship.field.FieldRepetitions.Count > 0)
        {
            _citizenship.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_citizenship, fieldData);
        }

        return _citizenship;
    } 
}

internal HL7V23Field _primaryLanguage;

public HL7V23Field PrimaryLanguage
{
    get
    {
        if (_primaryLanguage != null)
        {
            return _primaryLanguage;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.20",
            Type = @"Field",
            Position = @"NK1.20",
            Name = @"Primary Language",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0296",
            TableName = @"Primary language",
            Description = @"This field identifies the next of kin/associated party’s primary speaking language.  HL7 recommends using ISO 639 as the suggested values in user-defined table 0296 - Language",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.20.1",
                            Type = @"Component",
                            Position = @"NK1.20.1",
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
                            Id = @"NK1.20.2",
                            Type = @"Component",
                            Position = @"NK1.20.2",
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
                            Id = @"NK1.20.3",
                            Type = @"Component",
                            Position = @"NK1.20.3",
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
                            Id = @"NK1.20.4",
                            Type = @"Component",
                            Position = @"NK1.20.4",
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
                            Id = @"NK1.20.5",
                            Type = @"Component",
                            Position = @"NK1.20.5",
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
                            Id = @"NK1.20.6",
                            Type = @"Component",
                            Position = @"NK1.20.6",
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

        _primaryLanguage = new HL7V23Field
        {
            field = message[@"NK1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryLanguage.field.FieldRepetitions != null && _primaryLanguage.field.FieldRepetitions.Count > 0)
        {
            _primaryLanguage.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryLanguage, fieldData);
        }

        return _primaryLanguage;
    } 
}

internal HL7V23Field _livingArrangement;

public HL7V23Field LivingArrangement
{
    get
    {
        if (_livingArrangement != null)
        {
            return _livingArrangement;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.21",
            Type = @"Field",
            Position = @"NK1.21",
            Name = @"Living Arrangement",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0220",
            TableName = @"Living arrangement",
            Description = @"This field identifies the situation that the associated party lives in at his/her residential address.  Refer to user-defined table 0220 - Living arrangement for suggested values.  Examples of living arrangements might include Alone, Family, Institution, etc",
            Sample = @"",
            Fields = null
        }

        _livingArrangement = new HL7V23Field
        {
            field = message[@"NK1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingArrangement.field.FieldRepetitions != null && _livingArrangement.field.FieldRepetitions.Count > 0)
        {
            _livingArrangement.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_livingArrangement, fieldData);
        }

        return _livingArrangement;
    } 
}

internal HL7V23Field _publicityIndicator;

public HL7V23Field PublicityIndicator
{
    get
    {
        if (_publicityIndicator != null)
        {
            return _publicityIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.22",
            Type = @"Field",
            Position = @"NK1.22",
            Name = @"Publicity Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0215",
            TableName = @"Publicity code",
            Description = @"This field indicates what level of publicity is allowed (e.g., No Publicity, Family Only) for the next of kin/associated party.  Refer to user-defined table 0215 - Publicity code for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.22.1",
                            Type = @"Component",
                            Position = @"NK1.22.1",
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
                            Id = @"NK1.22.2",
                            Type = @"Component",
                            Position = @"NK1.22.2",
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
                            Id = @"NK1.22.3",
                            Type = @"Component",
                            Position = @"NK1.22.3",
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
                            Id = @"NK1.22.4",
                            Type = @"Component",
                            Position = @"NK1.22.4",
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
                            Id = @"NK1.22.5",
                            Type = @"Component",
                            Position = @"NK1.22.5",
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
                            Id = @"NK1.22.6",
                            Type = @"Component",
                            Position = @"NK1.22.6",
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

        _publicityIndicator = new HL7V23Field
        {
            field = message[@"NK1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_publicityIndicator.field.FieldRepetitions != null && _publicityIndicator.field.FieldRepetitions.Count > 0)
        {
            _publicityIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_publicityIndicator, fieldData);
        }

        return _publicityIndicator;
    } 
}

internal HL7V23Field _protectionIndicator;

public HL7V23Field ProtectionIndicator
{
    get
    {
        if (_protectionIndicator != null)
        {
            return _protectionIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.23",
            Type = @"Field",
            Position = @"NK1.23",
            Name = @"Protection Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies that next of kin/associated party’s protection that determines, in turn, whether access to information about this person should be kept from users who do not have adequate authority.  Refer to Chapter 2, HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _protectionIndicator = new HL7V23Field
        {
            field = message[@"NK1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_protectionIndicator.field.FieldRepetitions != null && _protectionIndicator.field.FieldRepetitions.Count > 0)
        {
            _protectionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_protectionIndicator, fieldData);
        }

        return _protectionIndicator;
    } 
}

internal HL7V23Field _studentIndicator;

public HL7V23Field StudentIndicator
{
    get
    {
        if (_studentIndicator != null)
        {
            return _studentIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.24",
            Type = @"Field",
            Position = @"NK1.24",
            Name = @"Student Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0231",
            TableName = @"Student status",
            Description = @"This field identifies whether the next of kin/associated party is currently a student or not, and whether the next of kin/associated party is a full- or a part-time student.  This field does not indicate the degree (high school, college) of the student or the field of study.  Refer to user-defined table 0231 - Student status for suggested values",
            Sample = @"",
            Fields = null
        }

        _studentIndicator = new HL7V23Field
        {
            field = message[@"NK1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studentIndicator.field.FieldRepetitions != null && _studentIndicator.field.FieldRepetitions.Count > 0)
        {
            _studentIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_studentIndicator, fieldData);
        }

        return _studentIndicator;
    } 
}

internal HL7V23Field _religion;

public HL7V23Field Religion
{
    get
    {
        if (_religion != null)
        {
            return _religion;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.25",
            Type = @"Field",
            Position = @"NK1.25",
            Name = @"Religion",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0006",
            TableName = @"Religion",
            Description = @"This field indicates the type of religion practiced by the next of kin/associated party.  Refer to user-defined table 0006 - Religion for suggested values",
            Sample = @"",
            Fields = null
        }

        _religion = new HL7V23Field
        {
            field = message[@"NK1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_religion.field.FieldRepetitions != null && _religion.field.FieldRepetitions.Count > 0)
        {
            _religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_religion, fieldData);
        }

        return _religion;
    } 
}

internal HL7V23Field _mothersMaidenName;

public HL7V23Field MothersMaidenName
{
    get
    {
        if (_mothersMaidenName != null)
        {
            return _mothersMaidenName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.26",
            Type = @"Field",
            Position = @"NK1.26",
            Name = @"Mother s Maiden Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the maiden name of the next of kin/associated party’s mother",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.26.1",
                            Type = @"Component",
                            Position = @"NK1.26.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.26.2",
                            Type = @"Component",
                            Position = @"NK1.26.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.26.3",
                            Type = @"Component",
                            Position = @"NK1.26.3",
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
                            Id = @"NK1.26.4",
                            Type = @"Component",
                            Position = @"NK1.26.4",
                            Name = @"Suffix",
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
                            Id = @"NK1.26.5",
                            Type = @"Component",
                            Position = @"NK1.26.5",
                            Name = @"Prefix",
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
                            Id = @"NK1.26.6",
                            Type = @"Component",
                            Position = @"NK1.26.6",
                            Name = @"Degree",
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
                            Id = @"NK1.26.7",
                            Type = @"Component",
                            Position = @"NK1.26.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.26.8",
                            Type = @"Component",
                            Position = @"NK1.26.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _mothersMaidenName = new HL7V23Field
        {
            field = message[@"NK1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mothersMaidenName.field.FieldRepetitions != null && _mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            _mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_mothersMaidenName, fieldData);
        }

        return _mothersMaidenName;
    } 
}

internal HL7V23Field _nationalityCode;

public HL7V23Field NationalityCode
{
    get
    {
        if (_nationalityCode != null)
        {
            return _nationalityCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.27",
            Type = @"Field",
            Position = @"NK1.27",
            Name = @"Nationality Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0212",
            TableName = @"Nationality",
            Description = @"This field identifies the nation or national group to which the next of kin/associated party belongs.  This information may be different than the person’s citizenship in countries in which multiple nationalities are recognized (e.g., Spain: Basque, Catalan, etc.). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.27.1",
                            Type = @"Component",
                            Position = @"NK1.27.1",
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
                            Id = @"NK1.27.2",
                            Type = @"Component",
                            Position = @"NK1.27.2",
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
                            Id = @"NK1.27.3",
                            Type = @"Component",
                            Position = @"NK1.27.3",
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
                            Id = @"NK1.27.4",
                            Type = @"Component",
                            Position = @"NK1.27.4",
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
                            Id = @"NK1.27.5",
                            Type = @"Component",
                            Position = @"NK1.27.5",
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
                            Id = @"NK1.27.6",
                            Type = @"Component",
                            Position = @"NK1.27.6",
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

        _nationalityCode = new HL7V23Field
        {
            field = message[@"NK1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nationalityCode.field.FieldRepetitions != null && _nationalityCode.field.FieldRepetitions.Count > 0)
        {
            _nationalityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nationalityCode, fieldData);
        }

        return _nationalityCode;
    } 
}

internal HL7V23Field _ethnicGroup;

public HL7V23Field EthnicGroup
{
    get
    {
        if (_ethnicGroup != null)
        {
            return _ethnicGroup;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.28",
            Type = @"Field",
            Position = @"NK1.28",
            Name = @"Ethnic Group",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0189",
            TableName = @"Ethnic group",
            Description = @"This field contains the next of kin/associated party’s ethnic group.  ERISA has a published list of ethnic classifications that may be used by local agreement at a site.  Refer to user-defined table 0189 - Ethnic group for suggested values",
            Sample = @"",
            Fields = null
        }

        _ethnicGroup = new HL7V23Field
        {
            field = message[@"NK1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ethnicGroup.field.FieldRepetitions != null && _ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            _ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_ethnicGroup, fieldData);
        }

        return _ethnicGroup;
    } 
}

internal HL7V23Field _contactReason;

public HL7V23Field ContactReason
{
    get
    {
        if (_contactReason != null)
        {
            return _contactReason;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.29",
            Type = @"Field",
            Position = @"NK1.29",
            Name = @"Contact Reason",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0222",
            TableName = @"Contact reason",
            Description = @"This field identifies how the contact should be used (e.g., contact my employer if patient is unable to work). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.29.1",
                            Type = @"Component",
                            Position = @"NK1.29.1",
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
                            Id = @"NK1.29.2",
                            Type = @"Component",
                            Position = @"NK1.29.2",
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
                            Id = @"NK1.29.3",
                            Type = @"Component",
                            Position = @"NK1.29.3",
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
                            Id = @"NK1.29.4",
                            Type = @"Component",
                            Position = @"NK1.29.4",
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
                            Id = @"NK1.29.5",
                            Type = @"Component",
                            Position = @"NK1.29.5",
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
                            Id = @"NK1.29.6",
                            Type = @"Component",
                            Position = @"NK1.29.6",
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

        _contactReason = new HL7V23Field
        {
            field = message[@"NK1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactReason.field.FieldRepetitions != null && _contactReason.field.FieldRepetitions.Count > 0)
        {
            _contactReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactReason, fieldData);
        }

        return _contactReason;
    } 
}

internal HL7V23Field _contactPersonsName;

public HL7V23Field ContactPersonsName
{
    get
    {
        if (_contactPersonsName != null)
        {
            return _contactPersonsName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.30",
            Type = @"Field",
            Position = @"NK1.30",
            Name = @"Contact Person's Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the names of the people to contact, depending on the value of the relationship defined in NK1-3-relationship.  This field is typically needed when the NK1 is an organization.  The legal name should be sent first in the sequence.  Refer to HL7 table 0200 - Name type for valid values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.30.1",
                            Type = @"Component",
                            Position = @"NK1.30.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.30.2",
                            Type = @"Component",
                            Position = @"NK1.30.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.30.3",
                            Type = @"Component",
                            Position = @"NK1.30.3",
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
                            Id = @"NK1.30.4",
                            Type = @"Component",
                            Position = @"NK1.30.4",
                            Name = @"Suffix",
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
                            Id = @"NK1.30.5",
                            Type = @"Component",
                            Position = @"NK1.30.5",
                            Name = @"Prefix",
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
                            Id = @"NK1.30.6",
                            Type = @"Component",
                            Position = @"NK1.30.6",
                            Name = @"Degree",
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
                            Id = @"NK1.30.7",
                            Type = @"Component",
                            Position = @"NK1.30.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.30.8",
                            Type = @"Component",
                            Position = @"NK1.30.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _contactPersonsName = new HL7V23Field
        {
            field = message[@"NK1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactPersonsName.field.FieldRepetitions != null && _contactPersonsName.field.FieldRepetitions.Count > 0)
        {
            _contactPersonsName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactPersonsName, fieldData);
        }

        return _contactPersonsName;
    } 
}

internal HL7V23Field _contactPersonsTelephoneNumber;

public HL7V23Field ContactPersonsTelephoneNumber
{
    get
    {
        if (_contactPersonsTelephoneNumber != null)
        {
            return _contactPersonsTelephoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.31",
            Type = @"Field",
            Position = @"NK1.31",
            Name = @"Contact Person s Telephone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone numbers of the contact person depending on the value of the relationship defined in NK1-3-relationship.  This field is typically needed when the NK1 is an organization.  The primary telephone number must be sent in the first sequence.  If the primary telephone number is not sent, then a repeat delimiter must be sent in the first sequence.  Refer to HL7 tables 0201 Telecommunication use code and 0202 - Telecommunication equipment type for valid values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.31.1",
                            Type = @"Component",
                            Position = @"NK1.31.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.31.2",
                            Type = @"Component",
                            Position = @"NK1.31.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.31.3",
                            Type = @"Component",
                            Position = @"NK1.31.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.31.4",
                            Type = @"Component",
                            Position = @"NK1.31.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.31.5",
                            Type = @"Component",
                            Position = @"NK1.31.5",
                            Name = @"Country Code",
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
                            Id = @"NK1.31.6",
                            Type = @"Component",
                            Position = @"NK1.31.6",
                            Name = @"Area/city Code",
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
                            Id = @"NK1.31.7",
                            Type = @"Component",
                            Position = @"NK1.31.7",
                            Name = @"Phone Number",
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
                            Id = @"NK1.31.8",
                            Type = @"Component",
                            Position = @"NK1.31.8",
                            Name = @"Extension",
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
                            Id = @"NK1.31.9",
                            Type = @"Component",
                            Position = @"NK1.31.9",
                            Name = @"Any Text",
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

        _contactPersonsTelephoneNumber = new HL7V23Field
        {
            field = message[@"NK1"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactPersonsTelephoneNumber.field.FieldRepetitions != null && _contactPersonsTelephoneNumber.field.FieldRepetitions.Count > 0)
        {
            _contactPersonsTelephoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactPersonsTelephoneNumber, fieldData);
        }

        return _contactPersonsTelephoneNumber;
    } 
}

internal HL7V23Field _contactPersonsAddress;

public HL7V23Field ContactPersonsAddress
{
    get
    {
        if (_contactPersonsAddress != null)
        {
            return _contactPersonsAddress;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.32",
            Type = @"Field",
            Position = @"NK1.32",
            Name = @"Contact Person s Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the addresses of the contact person depending on the value of the relationship defined in NK1-3-relationship.  This field is typically used when the NK1 is an organization.  When multiple addresses are sent, the mailing address must be sent first in the sequence",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.32.1",
                            Type = @"Component",
                            Position = @"NK1.32.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.32.2",
                            Type = @"Component",
                            Position = @"NK1.32.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.32.3",
                            Type = @"Component",
                            Position = @"NK1.32.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.32.4",
                            Type = @"Component",
                            Position = @"NK1.32.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"tate or province should be represented by the official postal service codes for that country",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.32.5",
                            Type = @"Component",
                            Position = @"NK1.32.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.32.6",
                            Type = @"Component",
                            Position = @"NK1.32.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.32.7",
                            Type = @"Component",
                            Position = @"NK1.32.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.32.8",
                            Type = @"Component",
                            Position = @"NK1.32.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.32.9",
                            Type = @"Component",
                            Position = @"NK1.32.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.32.10",
                            Type = @"Component",
                            Position = @"NK1.32.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _contactPersonsAddress = new HL7V23Field
        {
            field = message[@"NK1"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactPersonsAddress.field.FieldRepetitions != null && _contactPersonsAddress.field.FieldRepetitions.Count > 0)
        {
            _contactPersonsAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactPersonsAddress, fieldData);
        }

        return _contactPersonsAddress;
    } 
}

internal HL7V23Field _nextofkinassociatedpartyidentifiers;

public HL7V23Field Nextofkinassociatedpartyidentifiers
{
    get
    {
        if (_nextofkinassociatedpartyidentifiers != null)
        {
            return _nextofkinassociatedpartyidentifiers;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.33",
            Type = @"Field",
            Position = @"NK1.33",
            Name = @"Next of kin/associated party identifiers",
            Length = 32,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifiers for the next of kin/associated party, for example, Social Security Number, driver’s license, etc",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NK1.33.1",
                            Type = @"Component",
                            Position = @"NK1.33.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.33.2",
                            Type = @"Component",
                            Position = @"NK1.33.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NK1.33.3",
                            Type = @"Component",
                            Position = @"NK1.33.3",
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
                            Id = @"NK1.33.4",
                            Type = @"Component",
                            Position = @"NK1.33.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NK1.33.4.1",
                            Type = @"SubComponent",
                            Position = @"NK1.33.4.1",
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
                            Id = @"NK1.33.4.2",
                            Type = @"SubComponent",
                            Position = @"NK1.33.4.2",
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
                            Id = @"NK1.33.4.3",
                            Type = @"SubComponent",
                            Position = @"NK1.33.4.3",
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
                            Id = @"NK1.33.5",
                            Type = @"Component",
                            Position = @"NK1.33.5",
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
                            Id = @"NK1.33.6",
                            Type = @"Component",
                            Position = @"NK1.33.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NK1.33.6.1",
                            Type = @"SubComponent",
                            Position = @"NK1.33.6.1",
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
                            Id = @"NK1.33.6.2",
                            Type = @"SubComponent",
                            Position = @"NK1.33.6.2",
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
                            Id = @"NK1.33.6.3",
                            Type = @"SubComponent",
                            Position = @"NK1.33.6.3",
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

        _nextofkinassociatedpartyidentifiers = new HL7V23Field
        {
            field = message[@"NK1"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nextofkinassociatedpartyidentifiers.field.FieldRepetitions != null && _nextofkinassociatedpartyidentifiers.field.FieldRepetitions.Count > 0)
        {
            _nextofkinassociatedpartyidentifiers.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nextofkinassociatedpartyidentifiers, fieldData);
        }

        return _nextofkinassociatedpartyidentifiers;
    } 
}

internal HL7V23Field _jobStatus;

public HL7V23Field JobStatus
{
    get
    {
        if (_jobStatus != null)
        {
            return _jobStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.34",
            Type = @"Field",
            Position = @"NK1.34",
            Name = @"Job Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0311",
            TableName = @"Job status",
            Description = @"This field identifies the next of kin/associated party’s job status (full-time, part-time, permanent, etc.).  Refer to user-defined table 0311 - Job status for suggested values",
            Sample = @"",
            Fields = null
        }

        _jobStatus = new HL7V23Field
        {
            field = message[@"NK1"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobStatus.field.FieldRepetitions != null && _jobStatus.field.FieldRepetitions.Count > 0)
        {
            _jobStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_jobStatus, fieldData);
        }

        return _jobStatus;
    } 
}

internal HL7V23Field _race;

public HL7V23Field Race
{
    get
    {
        if (_race != null)
        {
            return _race;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.35",
            Type = @"Field",
            Position = @"NK1.35",
            Name = @"Race",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0005",
            TableName = @"Race",
            Description = @"This field identifies the race of the next of kin/associated party.  ERISA has published a list of ethnic classifications that may be used by local agreement at a site.  Refer to user-defined table 0005 - Race for suggested values",
            Sample = @"",
            Fields = null
        }

        _race = new HL7V23Field
        {
            field = message[@"NK1"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_race.field.FieldRepetitions != null && _race.field.FieldRepetitions.Count > 0)
        {
            _race.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_race, fieldData);
        }

        return _race;
    } 
}

internal HL7V23Field _handicap;

public HL7V23Field Handicap
{
    get
    {
        if (_handicap != null)
        {
            return _handicap;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.36",
            Type = @"Field",
            Position = @"NK1.36",
            Name = @"Handicap",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0295",
            TableName = @"Handicap",
            Description = @"This field contains the code that describes an associated party’s disability.  Refer to user-defined table 0295 - Handicap for suggested values",
            Sample = @"",
            Fields = null
        }

        _handicap = new HL7V23Field
        {
            field = message[@"NK1"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_handicap.field.FieldRepetitions != null && _handicap.field.FieldRepetitions.Count > 0)
        {
            _handicap.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_handicap, fieldData);
        }

        return _handicap;
    } 
}

internal HL7V23Field _contactPersonSocialSecurityNumber;

public HL7V23Field ContactPersonSocialSecurityNumber
{
    get
    {
        if (_contactPersonSocialSecurityNumber != null)
        {
            return _contactPersonSocialSecurityNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NK1.37",
            Type = @"Field",
            Position = @"NK1.37",
            Name = @"Contact Person Social Security Number",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the contact person’s social security number.  This number may also be an RR retirement number.  It is the number for the person identified in NK1-2-name.  For the Social Security number of the associated party, see NK1-33-next of kin/associated party’s identifiers",
            Sample = @"",
            Fields = null
        }

        _contactPersonSocialSecurityNumber = new HL7V23Field
        {
            field = message[@"NK1"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactPersonSocialSecurityNumber.field.FieldRepetitions != null && _contactPersonSocialSecurityNumber.field.FieldRepetitions.Count > 0)
        {
            _contactPersonSocialSecurityNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactPersonSocialSecurityNumber, fieldData);
        }

        return _contactPersonSocialSecurityNumber;
    } 
}
    }
}
