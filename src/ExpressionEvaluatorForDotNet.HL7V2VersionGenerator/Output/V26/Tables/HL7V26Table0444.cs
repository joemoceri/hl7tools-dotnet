using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0444
    {
        public string Id { get { return @"0444"; } }

        public string TableId { get { return @"0444"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Name assembly order"; } }

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
                            Value = @"F",
                            Description = @"Prefix Family Middle Given Suffix",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"G",
                            Description = @"Prefix Given Middle Family Suffix",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
