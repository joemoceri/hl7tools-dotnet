using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0749
    {
        public string Id { get { return @"0749"; } }

        public string TableId { get { return @"0749"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"DRG Grouping Status"; } }

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
                            Value = @"0",
                            Description = @"Valid code; not used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Valid code; used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Invalid code; not used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Invalid code; code is relevant for grouping",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
