using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0148
    {
        public string Id { get { return @"0148"; } }

        public string TableId { get { return @"0148"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Penalty type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Value = @"AT",
                            Description = @"Currency amount",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC",
                            Description = @"Percentage",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
