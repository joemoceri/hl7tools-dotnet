using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0366
    {
        public string Id { get { return @"0366"; } }

        public string TableId { get { return @"0366"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Local/remote control state"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

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
                            Value = @"L",
                            Description = @"Local",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Remote",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
