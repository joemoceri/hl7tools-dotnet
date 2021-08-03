using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0523
    {
        public string Id { get { return @"0523"; } }

        public string TableId { get { return @"0523"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Computation type"; } }

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
                            Value = @"%",
                            Description = @"Indicates a percent change",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"a",
                            Description = @"Absolute Change",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
