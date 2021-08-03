using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0155
    {
        public string Id { get { return @"0155"; } }

        public string TableId { get { return @"0155"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ACCEPT/APPLICATION ACKNOWLEDGEMENT CONDITIONS"; } }

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
                            Value = @"AL",
                            Description = @"Always",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ER",
                            Description = @"Error / reject conditions only",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NE",
                            Description = @"Never",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SU",
                            Description = @"Successful completion only",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
