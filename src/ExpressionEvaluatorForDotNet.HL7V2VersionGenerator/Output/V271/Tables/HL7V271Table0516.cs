using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0516
    {
        public string Id { get { return @"0516"; } }

        public string TableId { get { return @"0516"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Error Severity"; } }

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
                            Value = @"E",
                            Description = @"Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Fatal Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W",
                            Description = @"Warning",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
