using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0170
    {
        public string Id { get { return @"0170"; } }

        public string TableId { get { return @"0170"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"DERIVED SPECIMEN"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Description = @"Child observation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Not applicable",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Parent observation",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
