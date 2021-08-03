using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0020
    {
        public string Id { get { return @"0020"; } }

        public string TableId { get { return @"0020"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"UNUSED TABLE"; } }

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
                            Value = @"1",
                            Description = @"Moderate Manifestation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Moderate Manifestation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Major Manifestation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Catastrophic Manifestation",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
