using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0085
    {
        public string Id { get { return @"0085"; } }

        public string TableId { get { return @"0085"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"OBSERVATION RESULT STATUS"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"D",
                            Description = @"Delete previously transmitted observation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Complete/final results (entered and verified)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Specimen in lab--results pending",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Results entered - not verified",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Partial results",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
