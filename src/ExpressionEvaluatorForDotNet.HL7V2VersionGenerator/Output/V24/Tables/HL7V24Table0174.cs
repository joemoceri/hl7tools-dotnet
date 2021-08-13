using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0174
    {
        public string Id { get { return @"0174"; } }

        public string TableId { get { return @"0174"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Nature of service/test/observation"; } }

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
                            Value = @"A",
                            Description = @"Atomic service/test/observation (test code or treatment code)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Single observation calculated via a rule or formula from other independent observations (e.g., Alveolar--arterial ratio, cardiac output)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Functional procedure that may consist of one or more interrelated measures (e.g., glucose tolerance test, creatinine clearance), usually done at different times and/or on different specimens",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Profile or battery consisting of many independent atomic observations (e.g., SMA12, electrolytes), usually done at one instrument on one specimen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Superset--a set of batteries or procedures ordered under a single code unit but processed as separate batteries (e.g., routines = CBC, UA, electrolytes) This set indicates that the code being described is used to order multiple service/test/observation batteries.  For example, a client who routinely orders a CBC, a differential, and a thyroxine as an outpatient profile might use a single, special code to order all three test batteries, instead of having to submit three separate order codes.",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
