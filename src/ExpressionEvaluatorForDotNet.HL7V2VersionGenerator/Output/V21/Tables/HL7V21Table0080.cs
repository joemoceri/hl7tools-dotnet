using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0080
    {
        public string Id { get { return @"0080"; } }

        public string TableId { get { return @"0080"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"NATURE OF ABNORMAL TESTING"; } }

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
                            Value = @"A",
                            Description = @"An aged based population",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"None - generic normal range",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"A race based population",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"A sexed based population",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
