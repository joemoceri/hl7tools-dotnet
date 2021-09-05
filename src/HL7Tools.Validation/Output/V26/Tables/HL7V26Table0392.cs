using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0392
    {
        public string Id { get { return @"0392"; } }

        public string TableId { get { return @"0392"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Match reason"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

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
                            Value = @"DB",
                            Description = @"Match on Date of Birth",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"Match on Name (Alpha Match)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NP",
                            Description = @"Match on Name (Phonetic Match)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"Match on Social Security Number",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
