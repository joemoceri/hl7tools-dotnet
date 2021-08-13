using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0355
    {
        public string Id { get { return @"0355"; } }

        public string TableId { get { return @"0355"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Primary Key Value Type"; } }

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
                            Value = @"CE",
                            Description = @"Coded element",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CWE",
                            Description = @"Coded with Exceptions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PL",
                            Description = @"Person location",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
