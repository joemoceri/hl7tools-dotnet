using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0142
    {
        public string Id { get { return @"0142"; } }

        public string TableId { get { return @"0142"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Military Status"; } }

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
                            Value = @"ACT",
                            Description = @"Active duty",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEC",
                            Description = @"Deceased",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RET",
                            Description = @"Retired",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
