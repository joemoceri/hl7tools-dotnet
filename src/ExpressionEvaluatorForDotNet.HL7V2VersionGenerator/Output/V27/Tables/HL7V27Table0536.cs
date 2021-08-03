using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0536
    {
        public string Id { get { return @"0536"; } }

        public string TableId { get { return @"0536"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Certificate Status"; } }

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
                            Value = @"E",
                            Description = @"Expired",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Inactive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Provisional",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Revoked",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Active/Valid",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
