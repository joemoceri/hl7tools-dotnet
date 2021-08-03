using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0061
    {
        public string Id { get { return @"0061"; } }

        public string TableId { get { return @"0061"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Check digit scheme"; } }

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
                            Value = @"BCV",
                            Description = @"Bank Card Validation Number",
                            Comment = @"A non-embossed number included on bank cards and used to validate authenticity of the card and the person presenting the card"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO",
                            Description = @"ISO 7064: 1983",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M10",
                            Description = @"Mod 10 algorithm",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M11",
                            Description = @"Mod 11 algorithm",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NPI",
                            Description = @"Check digit algorithm in the US National Provider Identifier",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
