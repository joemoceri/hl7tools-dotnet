using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0387
    {
        public string Id { get { return @"0387"; } }

        public string TableId { get { return @"0387"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Command Response"; } }

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
                            Value = @"ER",
                            Description = @"Command cannot be completed because of error condition",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OK",
                            Description = @"Command completed successfully",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ST",
                            Description = @"Command cannot be completed because of the status of the requested equipment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TI",
                            Description = @"Command cannot be completed within requested completion time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UN",
                            Description = @"Command cannot be completed for unknown reasons",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
