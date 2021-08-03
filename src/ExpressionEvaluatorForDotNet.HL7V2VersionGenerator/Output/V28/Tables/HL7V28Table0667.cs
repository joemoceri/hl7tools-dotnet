using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0667
    {
        public string Id { get { return @"0667"; } }

        public string TableId { get { return @"0667"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Device Data State -"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",
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
                            Description = @"Real Time Values",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Historic Values",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
