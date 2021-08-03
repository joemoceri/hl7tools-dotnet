using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0092
    {
        public string Id { get { return @"0092"; } }

        public string TableId { get { return @"0092"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Re-Admission Indicator"; } }

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
                            Value = @"R",
                            Description = @"Re-admission",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
