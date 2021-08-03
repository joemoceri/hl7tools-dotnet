using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0109
    {
        public string Id { get { return @"0109"; } }

        public string TableId { get { return @"0109"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Report priority"; } }

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
                            Value = @"R",
                            Description = @"Routine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Stat",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
