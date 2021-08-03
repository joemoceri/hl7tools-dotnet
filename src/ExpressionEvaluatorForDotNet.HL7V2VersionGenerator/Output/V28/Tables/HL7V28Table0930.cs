using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0930
    {
        public string Id { get { return @"0930"; } }

        public string TableId { get { return @"0930"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Volume Units"; } }

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
                            Value = @"[pt_us]",
                            Description = @"Pint",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"l",
                            Description = @"Liter",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ml",
                            Description = @"Milliliters",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
