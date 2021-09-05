using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0501
    {
        public string Id { get { return @"0501"; } }

        public string TableId { get { return @"0501"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Consent Non-Disclosure Reason"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

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
                            Value = @"E",
                            Description = @"Emergency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PR",
                            Description = @"Patient Request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RX",
                            Description = @"Rx Private",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
