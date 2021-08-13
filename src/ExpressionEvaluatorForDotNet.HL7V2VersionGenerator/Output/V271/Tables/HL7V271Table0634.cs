using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0634
    {
        public string Id { get { return @"0634"; } }

        public string TableId { get { return @"0634"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Item Importance Codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

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
                            Value = @"CRT",
                            Description = @"Critical",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
