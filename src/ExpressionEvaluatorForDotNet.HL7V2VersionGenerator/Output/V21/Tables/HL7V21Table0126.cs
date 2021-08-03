using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0126
    {
        public string Id { get { return @"0126"; } }

        public string TableId { get { return @"0126"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"QUANTITY LIMITED REQUEST"; } }

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
                            Value = @"CH",
                            Description = @"Characters",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"Lines",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PG",
                            Description = @"Pages",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ZO",
                            Description = @"Locally defined",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
