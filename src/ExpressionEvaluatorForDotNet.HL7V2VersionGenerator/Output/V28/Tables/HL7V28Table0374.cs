using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0374
    {
        public string Id { get { return @"0374"; } }

        public string TableId { get { return @"0374"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"System Induced Contaminants"; } }

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
                            Value = @"CNTM",
                            Description = @"Present, type of contamination unspecified",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
