using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0231
    {
        public string Id { get { return @"0231"; } }

        public string TableId { get { return @"0231"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Student Status"; } }

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
                            Value = @"F",
                            Description = @"Full-time student",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Not a student",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Part-time student",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
