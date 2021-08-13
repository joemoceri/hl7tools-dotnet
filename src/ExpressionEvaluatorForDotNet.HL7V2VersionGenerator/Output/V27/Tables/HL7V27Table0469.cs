using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0469
    {
        public string Id { get { return @"0469"; } }

        public string TableId { get { return @"0469"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Packaging Status Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Value = @"0",
                            Description = @"Not packaged",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Packaged service (status indicator N, or no HCPCS code and certain revenue codes)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Packaged as part of partial hospitalization per diem or daily mental health service per diem",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
