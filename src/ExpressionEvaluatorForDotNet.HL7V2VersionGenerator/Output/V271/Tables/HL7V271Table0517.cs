using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0517
    {
        public string Id { get { return @"0517"; } }

        public string TableId { get { return @"0517"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Inform Person Code"; } }

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
                            Value = @"HD",
                            Description = @"Inform help desk",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NPAT",
                            Description = @"Do NOT inform patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAT",
                            Description = @"Inform patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USR",
                            Description = @"Inform User",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
