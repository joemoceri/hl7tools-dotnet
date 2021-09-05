using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0104
    {
        public string Id { get { return @"0104"; } }

        public string TableId { get { return @"0104"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Version ID"; } }

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
                            Value = @"2.0",
                            Description = @"Release 2.0",
                            Comment = @"September 1988"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.0D",
                            Description = @"Demo 2.0",
                            Comment = @"October 1988"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.1",
                            Description = @"Release 2. 1",
                            Comment = @"March 1990"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.2",
                            Description = @"Release 2.2",
                            Comment = @"December 1994"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.3",
                            Description = @"Release 2.3",
                            Comment = @"March 1997"
                        },
                        
                    };
            } 
        }
    }
}
