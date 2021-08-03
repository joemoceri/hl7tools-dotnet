using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0116
    {
        public string Id { get { return @"0116"; } }

        public string TableId { get { return @"0116"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"BED STATUS"; } }

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
                            Value = @"C",
                            Description = @"Closed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Housekeeping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Occupied",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
