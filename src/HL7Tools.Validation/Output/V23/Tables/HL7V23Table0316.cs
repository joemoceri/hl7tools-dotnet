using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0316
    {
        public string Id { get { return @"0316"; } }

        public string TableId { get { return @"0316"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Organ donor"; } }

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
                            Value = @"F",
                            Description = @"Yes, patient is a donor, but card is not on file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"No, patient does not have a living will but information was provided",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unknown",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"Yes, patient is a donor and card is on file",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
