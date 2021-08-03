using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0191
    {
        public string Id { get { return @"0191"; } }

        public string TableId { get { return @"0191"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Type of referenced data"; } }

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
                            Value = @"AP",
                            Description = @"Other application data, typically uninterpreted binary data (HL7 V2.3 and later)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AU",
                            Description = @"Audio data (HL7 V2.3 and later)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FT",
                            Description = @"Formatted text (HL7 V2.2 only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IM",
                            Description = @"Image data (HL7 V2.3 and later)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"multipart",
                            Description = @"MIME multipart package",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NS",
                            Description = @"Non-scanned image (HL7 V2.2 only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SD",
                            Description = @"Scanned document (HL7 V2.2 only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SI",
                            Description = @"Scanned image (HL7 V2.2 only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TEXT",
                            Description = @"Machine readable text document (HL7 V2.3.1 and later)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Machine readable text document (HL7 V2.2 only)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
