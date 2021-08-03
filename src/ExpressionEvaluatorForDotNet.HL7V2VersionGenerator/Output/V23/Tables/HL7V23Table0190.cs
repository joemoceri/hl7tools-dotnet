using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0190
    {
        public string Id { get { return @"0190"; } }

        public string TableId { get { return @"0190"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Address type"; } }

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
                            Value = @"B",
                            Description = @"Business",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Current Or Temporary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Country Of Origin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Home",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Mailing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Office",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Permanent",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
