using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0918
    {
        public string Id { get { return @"0918"; } }

        public string TableId { get { return @"0918"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"PCA Type"; } }

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
                            Value = @"C",
                            Description = @"Continuous",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"PCA Only",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC",
                            Description = @"PCA + Continuous",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
