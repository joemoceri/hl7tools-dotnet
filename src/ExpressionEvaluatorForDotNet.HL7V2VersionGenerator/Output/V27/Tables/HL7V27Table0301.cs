using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0301
    {
        public string Id { get { return @"0301"; } }

        public string TableId { get { return @"0301"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Universal ID Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"CLIA",
                            Description = @"Clinical Laboratory Improvement Amendments. Allows for the ability to designate organization identifier as a ""CLIA"" assigned number (for labs)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLIP",
                            Description = @"Clinical laboratory Improvement Program. Allows for the ability to designate organization identifier as a ""CLIP"" assigned number (for labs).Â  Used by US Department of Defense.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DNS",
                            Description = @"An Internet host name, in accordance with RFC 1035; or an IP address. Either in ASCII or as integers, with periods between components (""dotted"" notation).",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EUI64",
                            Description = @"IEEE 64-bit Extended Unique Identifier is comprised of a  24-bit company identifier and a 40-bit instance identifier.  The value shall be formatted as 16 ASCII HEX digits, for example, ""AABBCC1122334455"".  The 24-bit company identifier, formally known as ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GUID",
                            Description = @"Same as UUID.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HCD",
                            Description = @"The CEN Healthcare Coding Scheme Designator",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HL7",
                            Description = @"HL7 registration schemes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO",
                            Description = @"An International Standards Organization Object Identifier (OID), in accordance with ISO/IEC 8824.  Formatted as decimal digits separated by periods; recommended limit of 64 characters",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L,M,N",
                            Description = @"Locally defined coding entity identifier.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Random",
                            Description = @"Usually a base64 encoded string of random bits.<p>Note: Random IDs are typically used for instance identifiers, rather than an identifier of an Assigning Authority that issues instance identifiers",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"URI",
                            Description = @"Uniform Resource Identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UUID",
                            Description = @"The DCE Universal Unique Identifier, in accordance with RFC 4122. Recommended format is 32 hexadecimal digits separated by hyphens, in the digit grouping 8-4-4-4-12",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"x400",
                            Description = @"An X.400 MHS identifier. Recommended format is in accordance with RFC 1649",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"x500",
                            Description = @"An X.500 directory name",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
