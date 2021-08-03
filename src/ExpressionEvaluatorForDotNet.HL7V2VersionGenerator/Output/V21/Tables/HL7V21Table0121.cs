using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0121
    {
        public string Id { get { return @"0121"; } }

        public string TableId { get { return @"0121"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"RESPONSE FLAG"; } }

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
                            Value = @"E",
                            Description = @"Report exceptions only.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Same as D, plus confirmations explicitly.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Only the MSA segment is returned.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
