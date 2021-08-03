using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0225
    {
        public string Id { get { return @"0225"; } }

        public string TableId { get { return @"0225"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Escort Required"; } }

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
                            Value = @"N",
                            Description = @"Not Required",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Required",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unknown",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
