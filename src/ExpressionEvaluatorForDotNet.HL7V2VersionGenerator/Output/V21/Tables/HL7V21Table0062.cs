using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0062
    {
        public string Id { get { return @"0062"; } }

        public string TableId { get { return @"0062"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"EVENT REASON"; } }

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
                            Value = @"01",
                            Description = @"Patient Request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"Physician Order",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
