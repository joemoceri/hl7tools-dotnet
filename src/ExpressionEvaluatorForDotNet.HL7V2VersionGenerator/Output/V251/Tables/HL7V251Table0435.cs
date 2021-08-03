using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0435
    {
        public string Id { get { return @"0435"; } }

        public string TableId { get { return @"0435"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Advance Directive Code"; } }

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
                            Value = @"DNR",
                            Description = @"Do not resuscitate",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
