using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0557
    {
        public string Id { get { return @"0557"; } }

        public string TableId { get { return @"0557"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Payee Type"; } }

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
                            Value = @"EMPL",
                            Description = @"Employer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORG",
                            Description = @"Payee Organization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PERS",
                            Description = @"Person",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPER",
                            Description = @"Pay Person",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
