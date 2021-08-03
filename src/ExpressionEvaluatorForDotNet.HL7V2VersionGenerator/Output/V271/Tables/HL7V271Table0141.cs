using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0141
    {
        public string Id { get { return @"0141"; } }

        public string TableId { get { return @"0141"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Military Rank/Grade"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Value = @"E1... E9",
                            Description = @"Enlisted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O1 ... O9",
                            Description = @"Officers",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W1 ... W4",
                            Description = @"Warrant Officers",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
