using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0393
    {
        public string Id { get { return @"0393"; } }

        public string TableId { get { return @"0393"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Match Algorithms"; } }

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
                            Value = @"LINKSOFT_2.01",
                            Description = @"Proprietary algorithm for LinkSoft v2.01",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MATCHWARE_1.2",
                            Description = @"Proprietary algorithm for MatchWare v1.2",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
