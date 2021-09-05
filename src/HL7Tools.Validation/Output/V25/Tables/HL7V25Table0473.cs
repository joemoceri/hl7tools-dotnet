using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0473
    {
        public string Id { get { return @"0473"; } }

        public string TableId { get { return @"0473"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Formulary Status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

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
                            Value = @"G",
                            Description = @"This observation/service is on the formulary, and has guidelines",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"This observation/service is not on the formulary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"This observation/service is on the formulary, but is restricted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"This observation/service is on the formulary",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
