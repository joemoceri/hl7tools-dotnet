using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0191
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
                            Description = @"Other application data, typically uninterpreted binary data",
                            Comment = @"(new with HL7 v 2.3)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Application",
                            Description = @"Other application data, typically uninterpreted binary data",
                            Comment = @"(HL7 V2.3 and later)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AU",
                            Description = @"Audio data",
                            Comment = @"(new with HL7 v 2.3)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Audio",
                            Description = @"Audio data",
                            Comment = @"(HL7 V2.3 and later)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FT",
                            Description = @"Formatted text",
                            Comment = @"(HL7 V2.2 only)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FT",
                            Description = @"Formatted text",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IM",
                            Description = @"Image data",
                            Comment = @"(new  with HL7 v 2.3)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Image",
                            Description = @"Image data",
                            Comment = @"(HL7 V2.3 and later)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NS",
                            Description = @"Non-scanned image",
                            Comment = @"(HL7 V2.2 only)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NS",
                            Description = @"Non-scanned image",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SD",
                            Description = @"Scanned document",
                            Comment = @"(HL7 V2.2 only)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SI",
                            Description = @"Scanned image",
                            Comment = @"(HL7 V2.2 only)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SI",
                            Description = @"Scanned image",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TEXT",
                            Description = @"Machine readable text document",
                            Comment = @"(HL7 V2.3.1 and later)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Machine readable text document",
                            Comment = @"(HL7 V2.2 only)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Machine readable text document",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
