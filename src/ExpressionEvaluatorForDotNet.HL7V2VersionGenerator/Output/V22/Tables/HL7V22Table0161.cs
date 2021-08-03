using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0161
    {
        public string Id { get { return @"0161"; } }

        public string TableId { get { return @"0161"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ALLOW SUBSTITUTION"; } }

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
                            Description = @"Allow generic substitutions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Substitutions are not authorized",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Allow therapeutic substitutions",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
