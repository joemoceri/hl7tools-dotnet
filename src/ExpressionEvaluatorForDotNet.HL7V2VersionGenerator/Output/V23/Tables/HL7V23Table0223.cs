using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0223
    {
        public string Id { get { return @"0223"; } }

        public string TableId { get { return @"0223"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Living dependency"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

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
                            Value = @"CB",
                            Description = @"Common Bath",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Spouse dependent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Medical Supervision Required",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Small children",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WU",
                            Description = @"Walk up",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
