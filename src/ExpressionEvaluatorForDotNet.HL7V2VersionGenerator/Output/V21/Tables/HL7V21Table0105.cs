using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0105
    {
        public string Id { get { return @"0105"; } }

        public string TableId { get { return @"0105"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"SOURCE OF COMMENT"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"L",
                            Description = @"Ancillary department is source of comment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Orderer is source of comment",
                            Comment = null
                        },
                    };
            } 
        }
    }
}