using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0286
    {
        public string Id { get { return @"0286"; } }

        public string TableId { get { return @"0286"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Provider role"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",
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
                            Value = @"CP",
                            Description = @"Consulting Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PP",
                            Description = @"Primary Care Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Referring Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RT",
                            Description = @"Referred to Provider",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
