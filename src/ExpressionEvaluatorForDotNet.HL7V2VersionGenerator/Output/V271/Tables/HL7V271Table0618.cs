using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0618
    {
        public string Id { get { return @"0618"; } }

        public string TableId { get { return @"0618"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Protection Code"; } }

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
                            Value = @"LI",
                            Description = @"Listed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UL",
                            Description = @"Unlisted (Should not appear in directories)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UP",
                            Description = @"Unpublished",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
