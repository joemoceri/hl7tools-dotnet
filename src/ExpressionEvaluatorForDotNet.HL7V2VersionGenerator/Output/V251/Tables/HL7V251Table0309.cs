using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0309
    {
        public string Id { get { return @"0309"; } }

        public string TableId { get { return @"0309"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Coverage Type"; } }

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
                            Value = @"B",
                            Description = @"Both hospital and physician",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Hospital/institutional",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Physician/professional",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
