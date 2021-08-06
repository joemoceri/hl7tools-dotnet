using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0202
    {
        public string Id { get { return @"0202"; } }

        public string TableId { get { return @"0202"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Telecommunication Equipment Type"; } }

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
                            Description = @"Cellular or Mobile Phone",
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
                            Description = @"Internet Address",
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
                            Value = @"SAT",
                            Description = @"Satellite Phone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TDD",
                            Description = @"Telecommunications Device for the Deaf",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TTY",
                            Description = @"Teletypewriter",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X.400",
                            Description = @"X.400 email address",
                            Comment = null
                        },
                    };
            } 
        }
    }
}