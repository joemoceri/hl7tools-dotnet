using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0230
    {
        public string Id { get { return @"0230"; } }

        public string TableId { get { return @"0230"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Procedure Functional Type"; } }

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
                            Value = @"A",
                            Description = @"Anesthesia",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Diagnostic procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Invasive procedure not classified elsewhere (e.g., IV, catheter, etc.)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Procedure for treatment (therapeutic, including operations)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
