using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0298
    {
        public string Id { get { return @"0298"; } }

        public string TableId { get { return @"0298"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"CP Range Type"; } }

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
                            Value = @"F",
                            Description = @"Flat-rate. Apply the entire price to this interval, do not pro-rate the price if the full interval has not occurred/been consumed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Pro-rate. Apply this price to this interval, pro-rated by whatever portion of the interval has occurred/been consumed",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
