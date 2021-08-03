using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0921
    {
        public string Id { get { return @"0921"; } }

        public string TableId { get { return @"0921"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Certification Type Code"; } }

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
                            Value = @"ADM",
                            Description = @"Admitting",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PROC",
                            Description = @"Procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SERV",
                            Description = @"Service",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
