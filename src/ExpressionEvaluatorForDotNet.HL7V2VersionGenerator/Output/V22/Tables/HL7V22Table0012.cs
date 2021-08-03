using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0012
    {
        public string Id { get { return @"0012"; } }

        public string TableId { get { return @"0012"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"STOCK LOCATION"; } }

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
                            Value = @"AN",
                            Description = @"Filled from ancillary department stock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FL",
                            Description = @"Filled from floor stock",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
