using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0337
    {
        public string Id { get { return @"0337"; } }

        public string TableId { get { return @"0337"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Certification Status"; } }

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
                            Value = @"C",
                            Description = @"Certified",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"Eligible",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
