using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0210
    {
        public string Id { get { return @"0210"; } }

        public string TableId { get { return @"0210"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Relational Conjunction"; } }

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
                            Value = @"AND",
                            Description = @"Default",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OR",
                            Description = null,
                            Comment = null
                        },
                    };
            } 
        }
    }
}
