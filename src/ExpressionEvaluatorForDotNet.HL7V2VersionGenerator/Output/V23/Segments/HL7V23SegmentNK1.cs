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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentNK1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field setIDNextofKin;

public HL7V23Field SetIDNextofKin
{
    get
    {
        if (setIDNextofKin != null)
        {
            return setIDNextofKin;
        }

        setIDNextofKin = new HL7V23Field
        {
            field = message[@"NK1"][1],
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
        };

        // check for repetitions
        if (setIDNextofKin.field.FieldRepetitions != null && setIDNextofKin.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDNextofKin.Id));
            setIDNextofKin.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(setIDNextofKin, fieldData);
        }

        return setIDNextofKin;
    } 
}

internal HL7V23Field nKName;

public HL7V23Field NKName
{
    get
    {
        if (nKName != null)
        {
            return nKName;
        }

        nKName = new HL7V23Field
        {
            field = message[@"NK1"][2],
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
        };

        // check for repetitions
        if (nKName.field.FieldRepetitions != null && nKName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nKName.Id));
            nKName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(nKName, fieldData);
        }

        return nKName;
    } 
}

internal HL7V23Field relationship;

public HL7V23Field Relationship
{
    get
    {
        if (relationship != null)
        {
            return relationship;
        }

        relationship = new HL7V23Field
        {
            field = message[@"NK1"][3],
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
        };

        // check for repetitions
        if (relationship.field.FieldRepetitions != null && relationship.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(relationship.Id));
            relationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(relationship, fieldData);
        }

        return relationship;
    } 
}

internal HL7V23Field address;

public HL7V23Field Address
{
    get
    {
        if (address != null)
        {
            return address;
        }

        address = new HL7V23Field
        {
            field = message[@"NK1"][4],
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
        };

        // check for repetitions
        if (address.field.FieldRepetitions != null && address.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(address.Id));
            address.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(address, fieldData);
        }

        return address;
    } 
}

internal HL7V23Field phoneNumber;

public HL7V23Field PhoneNumber
{
    get
    {
        if (phoneNumber != null)
        {
            return phoneNumber;
        }

        phoneNumber = new HL7V23Field
        {
            field = message[@"NK1"][5],
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
        };

        // check for repetitions
        if (phoneNumber.field.FieldRepetitions != null && phoneNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(phoneNumber.Id));
            phoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(phoneNumber, fieldData);
        }

        return phoneNumber;
    } 
}

internal HL7V23Field businessPhoneNumber;

public HL7V23Field BusinessPhoneNumber
{
    get
    {
        if (businessPhoneNumber != null)
        {
            return businessPhoneNumber;
        }

        businessPhoneNumber = new HL7V23Field
        {
            field = message[@"NK1"][6],
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
        };

        // check for repetitions
        if (businessPhoneNumber.field.FieldRepetitions != null && businessPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(businessPhoneNumber.Id));
            businessPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(businessPhoneNumber, fieldData);
        }

        return businessPhoneNumber;
    } 
}

internal HL7V23Field contactRole;

public HL7V23Field ContactRole
{
    get
    {
        if (contactRole != null)
        {
            return contactRole;
        }

        contactRole = new HL7V23Field
        {
            field = message[@"NK1"][7],
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
        };

        // check for repetitions
        if (contactRole.field.FieldRepetitions != null && contactRole.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactRole.Id));
            contactRole.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(contactRole, fieldData);
        }

        return contactRole;
    } 
}

internal HL7V23Field startDate;

public HL7V23Field StartDate
{
    get
    {
        if (startDate != null)
        {
            return startDate;
        }

        startDate = new HL7V23Field
        {
            field = message[@"NK1"][8],
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
        };

        // check for repetitions
        if (startDate.field.FieldRepetitions != null && startDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(startDate.Id));
            startDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(startDate, fieldData);
        }

        return startDate;
    } 
}

internal HL7V23Field endDate;

public HL7V23Field EndDate
{
    get
    {
        if (endDate != null)
        {
            return endDate;
        }

        endDate = new HL7V23Field
        {
            field = message[@"NK1"][9],
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
        };

        // check for repetitions
        if (endDate.field.FieldRepetitions != null && endDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(endDate.Id));
            endDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(endDate, fieldData);
        }

        return endDate;
    } 
}

internal HL7V23Field nextofKinAssociatedPartiesJobTitle;

public HL7V23Field NextofKinAssociatedPartiesJobTitle
{
    get
    {
        if (nextofKinAssociatedPartiesJobTitle != null)
        {
            return nextofKinAssociatedPartiesJobTitle;
        }

        nextofKinAssociatedPartiesJobTitle = new HL7V23Field
        {
            field = message[@"NK1"][10],
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
        };

        // check for repetitions
        if (nextofKinAssociatedPartiesJobTitle.field.FieldRepetitions != null && nextofKinAssociatedPartiesJobTitle.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nextofKinAssociatedPartiesJobTitle.Id));
            nextofKinAssociatedPartiesJobTitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(nextofKinAssociatedPartiesJobTitle, fieldData);
        }

        return nextofKinAssociatedPartiesJobTitle;
    } 
}

internal HL7V23Field nextofKinJobAssociatedPartiesCodeClass;

public HL7V23Field NextofKinJobAssociatedPartiesCodeClass
{
    get
    {
        if (nextofKinJobAssociatedPartiesCodeClass != null)
        {
            return nextofKinJobAssociatedPartiesCodeClass;
        }

        nextofKinJobAssociatedPartiesCodeClass = new HL7V23Field
        {
            field = message[@"NK1"][11],
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
        };

        // check for repetitions
        if (nextofKinJobAssociatedPartiesCodeClass.field.FieldRepetitions != null && nextofKinJobAssociatedPartiesCodeClass.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nextofKinJobAssociatedPartiesCodeClass.Id));
            nextofKinJobAssociatedPartiesCodeClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(nextofKinJobAssociatedPartiesCodeClass, fieldData);
        }

        return nextofKinJobAssociatedPartiesCodeClass;
    } 
}

internal HL7V23Field nextofKinAssociatedPartiesEmployeeNumber;

public HL7V23Field NextofKinAssociatedPartiesEmployeeNumber
{
    get
    {
        if (nextofKinAssociatedPartiesEmployeeNumber != null)
        {
            return nextofKinAssociatedPartiesEmployeeNumber;
        }

        nextofKinAssociatedPartiesEmployeeNumber = new HL7V23Field
        {
            field = message[@"NK1"][12],
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
        };

        // check for repetitions
        if (nextofKinAssociatedPartiesEmployeeNumber.field.FieldRepetitions != null && nextofKinAssociatedPartiesEmployeeNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nextofKinAssociatedPartiesEmployeeNumber.Id));
            nextofKinAssociatedPartiesEmployeeNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(nextofKinAssociatedPartiesEmployeeNumber, fieldData);
        }

        return nextofKinAssociatedPartiesEmployeeNumber;
    } 
}

internal HL7V23Field organizationName;

public HL7V23Field OrganizationName
{
    get
    {
        if (organizationName != null)
        {
            return organizationName;
        }

        organizationName = new HL7V23Field
        {
            field = message[@"NK1"][13],
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
        };

        // check for repetitions
        if (organizationName.field.FieldRepetitions != null && organizationName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(organizationName.Id));
            organizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(organizationName, fieldData);
        }

        return organizationName;
    } 
}

internal HL7V23Field maritalStatus;

public HL7V23Field MaritalStatus
{
    get
    {
        if (maritalStatus != null)
        {
            return maritalStatus;
        }

        maritalStatus = new HL7V23Field
        {
            field = message[@"NK1"][14],
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
        };

        // check for repetitions
        if (maritalStatus.field.FieldRepetitions != null && maritalStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(maritalStatus.Id));
            maritalStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(maritalStatus, fieldData);
        }

        return maritalStatus;
    } 
}

internal HL7V23Field sex;

public HL7V23Field Sex
{
    get
    {
        if (sex != null)
        {
            return sex;
        }

        sex = new HL7V23Field
        {
            field = message[@"NK1"][15],
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
        };

        // check for repetitions
        if (sex.field.FieldRepetitions != null && sex.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sex.Id));
            sex.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(sex, fieldData);
        }

        return sex;
    } 
}

internal HL7V23Field dateofBirth;

public HL7V23Field DateofBirth
{
    get
    {
        if (dateofBirth != null)
        {
            return dateofBirth;
        }

        dateofBirth = new HL7V23Field
        {
            field = message[@"NK1"][16],
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
        };

        // check for repetitions
        if (dateofBirth.field.FieldRepetitions != null && dateofBirth.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateofBirth.Id));
            dateofBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(dateofBirth, fieldData);
        }

        return dateofBirth;
    } 
}

internal HL7V23Field livingDependency;

public HL7V23Field LivingDependency
{
    get
    {
        if (livingDependency != null)
        {
            return livingDependency;
        }

        livingDependency = new HL7V23Field
        {
            field = message[@"NK1"][17],
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
        };

        // check for repetitions
        if (livingDependency.field.FieldRepetitions != null && livingDependency.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(livingDependency.Id));
            livingDependency.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(livingDependency, fieldData);
        }

        return livingDependency;
    } 
}

internal HL7V23Field ambulatoryStatus;

public HL7V23Field AmbulatoryStatus
{
    get
    {
        if (ambulatoryStatus != null)
        {
            return ambulatoryStatus;
        }

        ambulatoryStatus = new HL7V23Field
        {
            field = message[@"NK1"][18],
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
        };

        // check for repetitions
        if (ambulatoryStatus.field.FieldRepetitions != null && ambulatoryStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ambulatoryStatus.Id));
            ambulatoryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(ambulatoryStatus, fieldData);
        }

        return ambulatoryStatus;
    } 
}

internal HL7V23Field citizenship;

public HL7V23Field Citizenship
{
    get
    {
        if (citizenship != null)
        {
            return citizenship;
        }

        citizenship = new HL7V23Field
        {
            field = message[@"NK1"][19],
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
        };

        // check for repetitions
        if (citizenship.field.FieldRepetitions != null && citizenship.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(citizenship.Id));
            citizenship.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(citizenship, fieldData);
        }

        return citizenship;
    } 
}

internal HL7V23Field primaryLanguage;

public HL7V23Field PrimaryLanguage
{
    get
    {
        if (primaryLanguage != null)
        {
            return primaryLanguage;
        }

        primaryLanguage = new HL7V23Field
        {
            field = message[@"NK1"][20],
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
        };

        // check for repetitions
        if (primaryLanguage.field.FieldRepetitions != null && primaryLanguage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryLanguage.Id));
            primaryLanguage.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(primaryLanguage, fieldData);
        }

        return primaryLanguage;
    } 
}

internal HL7V23Field livingArrangement;

public HL7V23Field LivingArrangement
{
    get
    {
        if (livingArrangement != null)
        {
            return livingArrangement;
        }

        livingArrangement = new HL7V23Field
        {
            field = message[@"NK1"][21],
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
        };

        // check for repetitions
        if (livingArrangement.field.FieldRepetitions != null && livingArrangement.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(livingArrangement.Id));
            livingArrangement.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(livingArrangement, fieldData);
        }

        return livingArrangement;
    } 
}

internal HL7V23Field publicityIndicator;

public HL7V23Field PublicityIndicator
{
    get
    {
        if (publicityIndicator != null)
        {
            return publicityIndicator;
        }

        publicityIndicator = new HL7V23Field
        {
            field = message[@"NK1"][22],
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
        };

        // check for repetitions
        if (publicityIndicator.field.FieldRepetitions != null && publicityIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(publicityIndicator.Id));
            publicityIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(publicityIndicator, fieldData);
        }

        return publicityIndicator;
    } 
}

internal HL7V23Field protectionIndicator;

public HL7V23Field ProtectionIndicator
{
    get
    {
        if (protectionIndicator != null)
        {
            return protectionIndicator;
        }

        protectionIndicator = new HL7V23Field
        {
            field = message[@"NK1"][23],
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
        };

        // check for repetitions
        if (protectionIndicator.field.FieldRepetitions != null && protectionIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(protectionIndicator.Id));
            protectionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(protectionIndicator, fieldData);
        }

        return protectionIndicator;
    } 
}

internal HL7V23Field studentIndicator;

public HL7V23Field StudentIndicator
{
    get
    {
        if (studentIndicator != null)
        {
            return studentIndicator;
        }

        studentIndicator = new HL7V23Field
        {
            field = message[@"NK1"][24],
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
        };

        // check for repetitions
        if (studentIndicator.field.FieldRepetitions != null && studentIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(studentIndicator.Id));
            studentIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(studentIndicator, fieldData);
        }

        return studentIndicator;
    } 
}

internal HL7V23Field religion;

public HL7V23Field Religion
{
    get
    {
        if (religion != null)
        {
            return religion;
        }

        religion = new HL7V23Field
        {
            field = message[@"NK1"][25],
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
        };

        // check for repetitions
        if (religion.field.FieldRepetitions != null && religion.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(religion.Id));
            religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(religion, fieldData);
        }

        return religion;
    } 
}

internal HL7V23Field mothersMaidenName;

public HL7V23Field MothersMaidenName
{
    get
    {
        if (mothersMaidenName != null)
        {
            return mothersMaidenName;
        }

        mothersMaidenName = new HL7V23Field
        {
            field = message[@"NK1"][26],
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
        };

        // check for repetitions
        if (mothersMaidenName.field.FieldRepetitions != null && mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(mothersMaidenName.Id));
            mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(mothersMaidenName, fieldData);
        }

        return mothersMaidenName;
    } 
}

internal HL7V23Field nationalityCode;

public HL7V23Field NationalityCode
{
    get
    {
        if (nationalityCode != null)
        {
            return nationalityCode;
        }

        nationalityCode = new HL7V23Field
        {
            field = message[@"NK1"][27],
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
        };

        // check for repetitions
        if (nationalityCode.field.FieldRepetitions != null && nationalityCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nationalityCode.Id));
            nationalityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(nationalityCode, fieldData);
        }

        return nationalityCode;
    } 
}

internal HL7V23Field ethnicGroup;

public HL7V23Field EthnicGroup
{
    get
    {
        if (ethnicGroup != null)
        {
            return ethnicGroup;
        }

        ethnicGroup = new HL7V23Field
        {
            field = message[@"NK1"][28],
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
        };

        // check for repetitions
        if (ethnicGroup.field.FieldRepetitions != null && ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ethnicGroup.Id));
            ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(ethnicGroup, fieldData);
        }

        return ethnicGroup;
    } 
}

internal HL7V23Field contactReason;

public HL7V23Field ContactReason
{
    get
    {
        if (contactReason != null)
        {
            return contactReason;
        }

        contactReason = new HL7V23Field
        {
            field = message[@"NK1"][29],
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
        };

        // check for repetitions
        if (contactReason.field.FieldRepetitions != null && contactReason.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactReason.Id));
            contactReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(contactReason, fieldData);
        }

        return contactReason;
    } 
}

internal HL7V23Field contactPersonsName;

public HL7V23Field ContactPersonsName
{
    get
    {
        if (contactPersonsName != null)
        {
            return contactPersonsName;
        }

        contactPersonsName = new HL7V23Field
        {
            field = message[@"NK1"][30],
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
        };

        // check for repetitions
        if (contactPersonsName.field.FieldRepetitions != null && contactPersonsName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactPersonsName.Id));
            contactPersonsName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(contactPersonsName, fieldData);
        }

        return contactPersonsName;
    } 
}

internal HL7V23Field contactPersonsTelephoneNumber;

public HL7V23Field ContactPersonsTelephoneNumber
{
    get
    {
        if (contactPersonsTelephoneNumber != null)
        {
            return contactPersonsTelephoneNumber;
        }

        contactPersonsTelephoneNumber = new HL7V23Field
        {
            field = message[@"NK1"][31],
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
        };

        // check for repetitions
        if (contactPersonsTelephoneNumber.field.FieldRepetitions != null && contactPersonsTelephoneNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactPersonsTelephoneNumber.Id));
            contactPersonsTelephoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(contactPersonsTelephoneNumber, fieldData);
        }

        return contactPersonsTelephoneNumber;
    } 
}

internal HL7V23Field contactPersonsAddress;

public HL7V23Field ContactPersonsAddress
{
    get
    {
        if (contactPersonsAddress != null)
        {
            return contactPersonsAddress;
        }

        contactPersonsAddress = new HL7V23Field
        {
            field = message[@"NK1"][32],
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
        };

        // check for repetitions
        if (contactPersonsAddress.field.FieldRepetitions != null && contactPersonsAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactPersonsAddress.Id));
            contactPersonsAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(contactPersonsAddress, fieldData);
        }

        return contactPersonsAddress;
    } 
}

internal HL7V23Field nextofkinassociatedpartyidentifiers;

public HL7V23Field Nextofkinassociatedpartyidentifiers
{
    get
    {
        if (nextofkinassociatedpartyidentifiers != null)
        {
            return nextofkinassociatedpartyidentifiers;
        }

        nextofkinassociatedpartyidentifiers = new HL7V23Field
        {
            field = message[@"NK1"][33],
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
        };

        // check for repetitions
        if (nextofkinassociatedpartyidentifiers.field.FieldRepetitions != null && nextofkinassociatedpartyidentifiers.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(nextofkinassociatedpartyidentifiers.Id));
            nextofkinassociatedpartyidentifiers.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(nextofkinassociatedpartyidentifiers, fieldData);
        }

        return nextofkinassociatedpartyidentifiers;
    } 
}

internal HL7V23Field jobStatus;

public HL7V23Field JobStatus
{
    get
    {
        if (jobStatus != null)
        {
            return jobStatus;
        }

        jobStatus = new HL7V23Field
        {
            field = message[@"NK1"][34],
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
        };

        // check for repetitions
        if (jobStatus.field.FieldRepetitions != null && jobStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(jobStatus.Id));
            jobStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(jobStatus, fieldData);
        }

        return jobStatus;
    } 
}

internal HL7V23Field race;

public HL7V23Field Race
{
    get
    {
        if (race != null)
        {
            return race;
        }

        race = new HL7V23Field
        {
            field = message[@"NK1"][35],
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
        };

        // check for repetitions
        if (race.field.FieldRepetitions != null && race.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(race.Id));
            race.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(race, fieldData);
        }

        return race;
    } 
}

internal HL7V23Field handicap;

public HL7V23Field Handicap
{
    get
    {
        if (handicap != null)
        {
            return handicap;
        }

        handicap = new HL7V23Field
        {
            field = message[@"NK1"][36],
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
        };

        // check for repetitions
        if (handicap.field.FieldRepetitions != null && handicap.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(handicap.Id));
            handicap.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(handicap, fieldData);
        }

        return handicap;
    } 
}

internal HL7V23Field contactPersonSocialSecurityNumber;

public HL7V23Field ContactPersonSocialSecurityNumber
{
    get
    {
        if (contactPersonSocialSecurityNumber != null)
        {
            return contactPersonSocialSecurityNumber;
        }

        contactPersonSocialSecurityNumber = new HL7V23Field
        {
            field = message[@"NK1"][37],
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
        };

        // check for repetitions
        if (contactPersonSocialSecurityNumber.field.FieldRepetitions != null && contactPersonSocialSecurityNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactPersonSocialSecurityNumber.Id));
            contactPersonSocialSecurityNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(contactPersonSocialSecurityNumber, fieldData);
        }

        return contactPersonSocialSecurityNumber;
    } 
}
    }
}
