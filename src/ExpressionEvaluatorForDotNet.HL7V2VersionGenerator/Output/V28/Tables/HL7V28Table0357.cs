using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0357
    {
        public string Id { get { return @"0357"; } }

        public string TableId { get { return @"0357"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Message Error Condition Codes"; } }

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
                            Value = @"0",
                            Description = @"Message accepted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"100",
                            Description = @"Segment sequence error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"101",
                            Description = @"Required field missing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"102",
                            Description = @"Data type error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"103",
                            Description = @"Table value not found",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"104",
                            Description = @"Value too long",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"200",
                            Description = @"Unsupported message type",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"201",
                            Description = @"Unsupported event code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"202",
                            Description = @"Unsupported processing id",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"203",
                            Description = @"Unsupported version id",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"204",
                            Description = @"Unknown key identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"205",
                            Description = @"Duplicate key identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"206",
                            Description = @"Application record locked",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"207",
                            Description = @"Application internal error",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
