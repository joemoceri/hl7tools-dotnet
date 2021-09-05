using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0167
    {
        public string Id { get { return @"0167"; } }

        public string TableId { get { return @"0167"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"SUBSTITUTION STATUS"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Value = @"G",
                            Description = @"A generic substitution was dispensed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"No substitute was dispensed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"A therapeutic substitution was dispensed",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
