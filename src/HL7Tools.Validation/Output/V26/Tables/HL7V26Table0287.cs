using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0287
    {
        public string Id { get { return @"0287"; } }

        public string TableId { get { return @"0287"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Problem/goal action code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",

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
                            Value = @"AD",
                            Description = @"ADD",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CO",
                            Description = @"CORRECT",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DE",
                            Description = @"DELETE",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"LINK",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UC",
                            Description = @"UNCHANGED",
                            Comment = @"The UNCHANGED action code is used to signify to the applications programs that this particular segment includes no information to be modified.  It is supplied in order to identify the correct record for which the following modification is intended. "
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UN",
                            Description = @"UNLINK",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UP",
                            Description = @"UPDATE",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
