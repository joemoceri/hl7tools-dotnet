using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeRP
    {
        public string Id { get { return @"RP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Reference Pointer"; } }

        public string Description { get { return @"This data type transmits information about data stored on another system. It contains a reference pointer that uniquely identifies the data on the other system, the identity of the other system, and the type of data."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 0; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RP.1",
                            Type = @"DataTypeComponent",
                            Position = @"RP.1",
                            Name = @"Pointer",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A key to the referenced data assigned by the system that stores the data. The key, which is an ST data type, is used to identify and access the data, either as an object identifier, or as a hierarchical name or query string.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RP.2",
                            Type = @"DataTypeComponent",
                            Position = @"RP.2",
                            Name = @"Application Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"A unique designator of the system that stores the data. It is an HD data type (See Section 2.A.33, ""HD - hierarchic designator""). Application ID’s must be unique across a given HL7 implementation.

Usage Note: The Application ID together with the Pointer may form a Uniform Resource Identifier (URI) in accordance with RFC 2396.  In this case the Application ID shall include the Scheme and Authority parts of the URI, and the Path part if that points to an application. The Pointer shall include the Query part of the URI, or the Path part if that points to an object. All delimiters between URI parts (“:”, “/”, “?”) should be included in the components.

Referenced data may be obtained by a mechanism not defined in the HL7 standard. The Scheme part of a URI in the Application ID specifies the access protocol, e.g., HTTP or FTP.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RP.3",
                            Type = @"DataTypeComponent",
                            Position = @"RP.3",
                            Name = @"Type Of Data",
                            Length = 11,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0834",
                            TableName = @"MIME Types",
                            Description = @"An ID data type that declares the general type of data. Refer to Imported Table 0834 – MIME Types for valid values. Table 0834 comprises the values of MIME media types established in accordance with RFC 2046 (http://ietf.org/rfc/rfc2046.txt) and registered with the Internet Assigned Numbers Authority (http://www.iana.org/numbers.html). Note that the MIME media type values are case-insensitive, in accordance with RFC 2045.

Note: HL7 Table 0191- Type of Referenced Data is retained for backward compatibility as of v2.6.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RP.4",
                            Type = @"DataTypeComponent",
                            Position = @"RP.4",
                            Name = @"Subtype",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0291",
                            TableName = @"Subtype of Referenced Data",
                            Description = @"An ID data type declaring the format for the referenced. Refer to Externally-defined Table 0291 – Subtype of Referenced Data for valid values. Table 0291 comprises the values of MIME media subtypes established in accordance with RFC 2046 (http://ietf.org/rfc/rfc2046.txt) and registered with the Internet Assigned Numbers Authority (http://www.iana.org/numbers.html). Note that the MIME media subtype values are case-insensitive, in accordance with RFC 2045.

HL7 approved ""standard"" extensions as defined in table 0291 are allowed.

Additional subtypes may be added to this Standard. All subtypes registered by IANA may be used by implementation agreement between cooperating parties. In addition, private, non-standard subtypes may be defined by agreement between cooperating parties. All private, non-standard subtypes should begin with the character combination “X-” to distinguish them from the standard subtypes, in accordance with RFC 2045.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
