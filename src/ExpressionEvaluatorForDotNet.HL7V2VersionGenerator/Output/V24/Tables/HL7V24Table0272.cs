using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0272
    {
        public string Id { get { return @"0272"; } }

        public string TableId { get { return @"0272"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Document confidentiality status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",
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
                            Description = @"Restricted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Usual control",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Very restricted",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
