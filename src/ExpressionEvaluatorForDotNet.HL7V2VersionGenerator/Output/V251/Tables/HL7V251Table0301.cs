using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0301
    {
        public string Id { get { return @"0301"; } }

        public string TableId { get { return @"0301"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Universal ID type"; } }

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
                            Value = @"DNS",
                            Description = @"An Internet dotted name. Either in ASCII or as integers",
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
                            Description = @"The CEN Healthcare Coding Scheme Designator. (Identifiers used in DICOM follow this assignment scheme.)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HL7",
                            Description = @"Reserved for future HL7 registration schemes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO",
                            Description = @"An International Standards Organization Object Identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L,M,N",
                            Description = @"These are reserved for locally defined coding schemes.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Random",
                            Description = @"Usually a base64 encoded string of random bits. The uniqueness depends on the length of the bits. Mail systems often generate ASCII string “unique names,"" from a combination of random bits and system names. Obviously, such identifiers will not be constrained to the base64 character set.",
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
                            Description = @"The DCE Universal Unique Identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"x400",
                            Description = @"An X.400 MHS format identifier",
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
