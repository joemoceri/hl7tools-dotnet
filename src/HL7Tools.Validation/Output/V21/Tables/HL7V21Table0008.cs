using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0008
    {
        public string Id { get { return @"0008"; } }

        public string TableId { get { return @"0008"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ACKNOWLEDGMENT CODE"; } }

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
                            Value = @"AA",
                            Description = @"Application Accept",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AE",
                            Description = @"Application Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AR",
                            Description = @"Application Reject",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
