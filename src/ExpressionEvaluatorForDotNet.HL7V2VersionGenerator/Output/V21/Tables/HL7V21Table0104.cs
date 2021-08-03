using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0104
    {
        public string Id { get { return @"0104"; } }

        public string TableId { get { return @"0104"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"VERSION CONTROL TABLE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Description = @"Release 2.0  September 1988",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.0D",
                            Description = @"Demo    2.0  October 1988",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.1",
                            Description = @"Release 2.1  March 1990",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
