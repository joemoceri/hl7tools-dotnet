using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0564
    {
        public string Id { get { return @"0564"; } }

        public string TableId { get { return @"0564"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Adjustment Category Code"; } }

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
                            Value = @"EA",
                            Description = @"Edit/Adjudication Response",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Provider Adjustment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PR",
                            Description = @"Processing Result",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
