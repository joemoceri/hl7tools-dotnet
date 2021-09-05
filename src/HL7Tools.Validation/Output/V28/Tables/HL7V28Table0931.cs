using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0931
    {
        public string Id { get { return @"0931"; } }

        public string TableId { get { return @"0931"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Temperature Units"; } }

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
                            Value = @"Cel",
                            Description = @"Degrees Celsius",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"degF",
                            Description = @"Degrees Fahrenheit",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
