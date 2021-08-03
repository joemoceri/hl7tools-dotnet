using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0208
    {
        public string Id { get { return @"0208"; } }

        public string TableId { get { return @"0208"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Query response status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
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
                            Value = @"AE",
                            Description = @"Application error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AR",
                            Description = @"Application reject",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NF",
                            Description = @"No data found, no errors",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OK",
                            Description = @"Data found, no errors (this is the default)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
