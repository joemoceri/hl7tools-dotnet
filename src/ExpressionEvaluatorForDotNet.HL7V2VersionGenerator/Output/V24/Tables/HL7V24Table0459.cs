using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0459
    {
        public string Id { get { return @"0459"; } }

        public string TableId { get { return @"0459"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Reimbursement Action Code"; } }

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
                            Description = @"OCE line item denial or rejection is not ignored",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"OCE line item denial or rejection is ignored",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"External line item denial. Line item is denied even if no OCE edits",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"External line item rejection. Line item is rejected even if no OCE edits",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
