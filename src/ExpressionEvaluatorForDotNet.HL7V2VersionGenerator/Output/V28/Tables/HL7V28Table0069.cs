using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0069
    {
        public string Id { get { return @"0069"; } }

        public string TableId { get { return @"0069"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Hospital Service"; } }

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
                            Value = @"CAR",
                            Description = @"Cardiac Service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MED",
                            Description = @"Medical Service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PUL",
                            Description = @"Pulmonary Service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUR",
                            Description = @"Surgical Service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"URO",
                            Description = @"Urology Service",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
