using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0401
    {
        public string Id { get { return @"0401"; } }

        public string TableId { get { return @"0401"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Government Reimbursement Program"; } }

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
                            Value = @"C",
                            Description = @"Medi-Cal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MM",
                            Description = @"Medicare",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
