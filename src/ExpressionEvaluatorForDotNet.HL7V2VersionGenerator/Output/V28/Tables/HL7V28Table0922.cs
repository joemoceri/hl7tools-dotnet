using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0922
    {
        public string Id { get { return @"0922"; } }

        public string TableId { get { return @"0922"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Certification Category Code"; } }

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
                            Value = @"IR",
                            Description = @"Initial Request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RA",
                            Description = @"Request for Appeal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Request for Extension",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
