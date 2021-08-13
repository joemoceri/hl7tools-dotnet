using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0211
    {
        public string Id { get { return @"0211"; } }

        public string TableId { get { return @"0211"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Alternate character sets"; } }

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
                            Value = @"8859/1",
                            Description = @"The printable characters from the ISO 8859/1 Character set",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8859/2",
                            Description = @"The printable characters from the ISO 8859/2 Character set",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8859/3",
                            Description = @"The printable characters from the ISO 8859/3 Character set",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8859/4",
                            Description = @"The printable characters from the ISO 8859/4 Character set",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8859/5",
                            Description = @"The printable characters from the ISO 8859/5 Character set",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8859/6",
                            Description = @"The printable characters from the ISO 8859/6 Character set",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8859/7",
                            Description = @"The printable characters from the ISO 8859/7 Character set",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8859/8",
                            Description = @"The printable characters from the ISO 8859/8 Character set",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8859/9",
                            Description = @"The printable characters from the ISO 8859/9 Character set",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ASCII",
                            Description = @"The printable 7-bit ASCII character set.",
                            Comment = @"(This is the default if this field is omitted)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BIG-5",
                            Description = @"Code for Taiwanese Character Set (BIG-5)",
                            Comment = @"Does not need an escape sequence. BIG-5 does not need an escape sequence. ASCII is a 7 bit character set, which means that the top bit of the byte is ""0"". The parser knows that when the top bit of the byte is ""0"", the character set is ASCII. When it is ""1"", the following bytes should be handled as 2 bytes (or more). No escape technique is needed. However, since some servers do not correctly interpret when they receive a top bit ""1"", it is advised, in internet RFC, to not use these kind of non-safe non-escape extension."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNS 11643-1992",
                            Description = @"Code for Taiwanese Character Set (CNS 11643-1992)",
                            Comment = @"Does not need an escape sequence."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GB 18030-2000",
                            Description = @"Code for Chinese Character Set (GB 18030-2000)",
                            Comment = @"Does not need an escape sequence."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO IR14",
                            Description = @"Code for Information Exchange (one byte)(JIS X 0201-1976).",
                            Comment = @"Note that the code contains a space, i.e. ""ISO IR14""."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO IR159",
                            Description = @"Code of the supplementary Japanese Graphic Character set for information interchange (JIS X 0212-1990).",
                            Comment = @"Note that the code contains a space, i.e. ""ISO IR159""."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO IR87",
                            Description = @"Code for the Japanese Graphic Character set for information interchange (JIS X 0208-1990),",
                            Comment = @"Note that the code contains a space, i.e. ""ISO IR87"". The JIS X 0208 needs an escape sequence. In Japan, the escape technique is ISO 2022. From basic ASCII, escape sequence ""escape"" $ B (in HEX, 1B 24 42) lets the parser know that following bytes should be handled 2-byte wise. Back to ASCII is 1B 28 42."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KS X 1001",
                            Description = @"Code for Korean Character Set (KS X 1001)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNICODE",
                            Description = @"The world wide character standard from ISO/IEC 10646-1-1993[6]",
                            Comment = @"Deprecated. Retained for backward compatibility only as v 2.5. Replaced by specific Unicode encoding codes."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNICODE UTF-16",
                            Description = @"UCS Transformation Format, 16-bit form",
                            Comment = @"UTF-16 is identical to ISO/IEC 10646 UCS-2. Note that the code contains a space before UTF but not before and after the hyphen."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNICODE UTF-32",
                            Description = @"UCS Transformation Format, 32-bit form",
                            Comment = @"UTF-32 is defined by Unicode Technical Report #19, and is an officially recognized encoding as of Unicode Version 3.1. UTF-32 is a proper subset of ISO/IEC 10646 UCS-4. Note that the code contains a space before UTF but not before and after the hyphen."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNICODE UTF-8",
                            Description = @"UCS Transformation Format, 8-bit form",
                            Comment = @"UTF-8 is a variable-length encoding, each code value is represented by 1,2 or 3 bytes, depending on the code value. 7 bit ASCII is a proper subset of UTF-8. Note that the code contains a space before UTF but not before and after the hyphen."
                        },
                        
                    };
            } 
        }
    }
}
