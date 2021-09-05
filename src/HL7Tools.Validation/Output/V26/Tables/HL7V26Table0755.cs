using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0755
    {
        public string Id { get { return @"0755"; } }

        public string TableId { get { return @"0755"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Status Weight At Birth"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Value = @"0",
                            Description = @"No weight reported at admission used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Weight reported at admission used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Default weight (>2499g) used for grouping",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
