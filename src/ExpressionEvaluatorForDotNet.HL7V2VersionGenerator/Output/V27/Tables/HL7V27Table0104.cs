using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0104
    {
        public string Id { get { return @"0104"; } }

        public string TableId { get { return @"0104"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Version ID"; } }

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
                            Value = @"2.0",
                            Description = @"Release 2.0",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.0D",
                            Description = @"Demo 2.0",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.1",
                            Description = @"Release 2.1",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.2",
                            Description = @"Release 2.2",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.3",
                            Description = @"Release 2.3",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.3.1",
                            Description = @"Release 2.3.1",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.4",
                            Description = @"Release 2.4",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.5",
                            Description = @"Release 2.5",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.5.1",
                            Description = @"Release 2.5.1",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.6",
                            Description = @"Release 2.6",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.7",
                            Description = @"Release 2.7",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
