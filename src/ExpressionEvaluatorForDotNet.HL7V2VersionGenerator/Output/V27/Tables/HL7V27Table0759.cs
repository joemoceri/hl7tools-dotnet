using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0759
    {
        public string Id { get { return @"0759"; } }

        public string TableId { get { return @"0759"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Status Admission"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Description = @"Admission status is valid; used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Admission status is valid; not used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Admission status is invalid; not used for grouping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Admission status is invalid; default value used for grouping",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
