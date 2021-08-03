using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0540
    {
        public string Id { get { return @"0540"; } }

        public string TableId { get { return @"0540"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Inactive Reason Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",
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
                            Value = @"L",
                            Description = @"Leave of Absence",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Retired",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Termination",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
