using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0202
    {
        public string Id { get { return @"0202"; } }

        public string TableId { get { return @"0202"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Telecommunication equipment type"; } }

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
                            Value = @"BP",
                            Description = @"Beeper",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Cellular Phone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FX",
                            Description = @"Fax",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Internet",
                            Description = @"Internet Address: Use Only If TelecommunicationUse Code Is NET",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MD",
                            Description = @"Modem",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PH",
                            Description = @"Telephone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X.400",
                            Description = @"X.400 email address: Use Only If TelecommunicationUse Code Is NET",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
