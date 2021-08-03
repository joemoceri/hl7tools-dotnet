using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0317
    {
        public string Id { get { return @"0317"; } }

        public string TableId { get { return @"0317"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Annotations"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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
                            Value = @"9900",
                            Description = @"Pace spike",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"9901",
                            Description = @"SAS marker",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"9902",
                            Description = @"Sense marker",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"9903",
                            Description = @"Beat marker",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"9904",
                            Description = @"etc.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
