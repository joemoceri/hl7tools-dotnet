using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0919
    {
        public string Id { get { return @"0919"; } }

        public string TableId { get { return @"0919"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Exclusive Test"; } }

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
                            Value = @"D",
                            Description = @"In some cases, this test should be only exclusively with like tests (examples are cyto or pathology)",
                            Comment = @"When  D is specified for this field, using field OM1-49 determines how tests must be grouped together.  Tests within the same Diagnostic Service Sector may be on the same requisition, and therefore in the same message"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"This test can be included with any number of other tests",
                            Comment = @"Default –.will be assumed when this field is empty"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"This test should be exclusive",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
