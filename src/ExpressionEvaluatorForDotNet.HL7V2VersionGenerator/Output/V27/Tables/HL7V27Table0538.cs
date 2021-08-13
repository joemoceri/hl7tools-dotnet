using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0538
    {
        public string Id { get { return @"0538"; } }

        public string TableId { get { return @"0538"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Institution Relationship Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

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
                            Value = @"CON",
                            Description = @"Contractor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CST",
                            Description = @"Consultant",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EMP",
                            Description = @"Employee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VOL",
                            Description = @"Volunteer",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
