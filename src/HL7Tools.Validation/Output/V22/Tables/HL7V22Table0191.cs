using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0191
    {
        public string Id { get { return @"0191"; } }

        public string TableId { get { return @"0191"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"TYPE OF DATA"; } }

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
                            Value = @"FT",
                            Description = @"Formatted Text",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NS",
                            Description = @"Non-scanned Image",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SD",
                            Description = @"Scanned Document",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SI",
                            Description = @"Scanned Image",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Machine Readable Text Document",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
