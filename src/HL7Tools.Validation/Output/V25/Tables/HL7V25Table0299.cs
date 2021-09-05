using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0299
    {
        public string Id { get { return @"0299"; } }

        public string TableId { get { return @"0299"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Encoding"; } }

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
                            Value = @"A",
                            Description = @"No encoding - data are displayable ASCII characters.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Base64",
                            Description = @"Encoding as defined by MIME (Multipurpose Internet Mail Extensions) standard RFC 1521. Four consecutive ASCII characters represent three consecutive octets of binary data. Base64 utilizes a 65-character subset of US-ASCII, consisting of both the upper and lower case alphabetic characters, digits ""0"" through “9”, “+"", “/"", and “=”.",
                            Comment = @"The Request For Comment (RFC) 1521 standard is available at: http://www.ietf.org/rfc/rfc1521.txt"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Hex",
                            Description = @"Hexadecimal encoding - consecutive pairs of hexadecimal digits represent consecutive single octets.",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
