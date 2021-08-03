using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0211
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
                            Description = @"The printable 7-bit ASCII character set. (This is the default if this field is omitted)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JAS2020",
                            Description = @"A subset of ISO2020 used for most Kanjii transmissions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JIS X 0202",
                            Description = @"ISO 2022 with escape sequences for Kanjii",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNICODE",
                            Description = @"The world wide character standard from ISO/IEC 10646-1-1993[3]",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
