using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0375
    {
        public string Id { get { return @"0375"; } }

        public string TableId { get { return @"0375"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Artificial Blood"; } }

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
                            Value = @"FLUR",
                            Description = @"Fluorocarbons",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SFHB",
                            Description = @"Stromal free hemoglobin preparations",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
