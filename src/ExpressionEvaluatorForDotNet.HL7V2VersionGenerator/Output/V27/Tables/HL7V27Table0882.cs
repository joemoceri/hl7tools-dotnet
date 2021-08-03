using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0882
    {
        public string Id { get { return @"0882"; } }

        public string TableId { get { return @"0882"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Medical Role Executing Physician"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Description = @"Employed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SE",
                            Description = @"Self-employed",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
