using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0569
    {
        public string Id { get { return @"0569"; } }

        public string TableId { get { return @"0569"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Adjustment Action"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Value = @"EOB",
                            Description = @"Print on EOB",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAT",
                            Description = @"Inform Patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRO",
                            Description = @"Inform Provider",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
