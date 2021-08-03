using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0402
    {
        public string Id { get { return @"0402"; } }

        public string TableId { get { return @"0402"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"School type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",
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
                            Value = @"D",
                            Description = @"Dental",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"G",
                            Description = @"Graduate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Medical",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Undergraduate",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
