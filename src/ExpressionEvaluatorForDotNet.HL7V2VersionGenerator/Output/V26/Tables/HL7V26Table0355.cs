using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0355
    {
        public string Id { get { return @"0355"; } }

        public string TableId { get { return @"0355"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Primary key value type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"CE",
                            Description = @"Coded element",
                            Comment = @"Withdrawn as of v2.6 - CE has been replaced by CNE and CWE"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CWE",
                            Description = @"Coded with Exceptions",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PL",
                            Description = @"Person location",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
