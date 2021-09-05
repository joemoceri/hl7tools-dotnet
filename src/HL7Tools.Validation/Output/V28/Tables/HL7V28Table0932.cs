using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0932
    {
        public string Id { get { return @"0932"; } }

        public string TableId { get { return @"0932"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Donation Duration Units"; } }

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
                            Value = @"min",
                            Description = @"Minutes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"s",
                            Description = @"Seconds",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
