using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0147
    {
        public string Id { get { return @"0147"; } }

        public string TableId { get { return @"0147"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Policy type"; } }

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
                            Value = @"2ANC",
                            Description = @"Second ancillary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2MMD",
                            Description = @"Second major medical",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3MMD",
                            Description = @"Third major medical",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANC",
                            Description = @"Ancillary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MMD",
                            Description = @"Major medical",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
