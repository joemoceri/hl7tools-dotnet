using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0616
    {
        public string Id { get { return @"0616"; } }

        public string TableId { get { return @"0616"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Address Expiration Reason"; } }

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
                            Value = @"C",
                            Description = @"Corrected",
                            Comment = @"The address has been replaced with a corrected version"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"Added in error",
                            Comment = @"The address was incorrect and should never have been associated with the individual"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Moved",
                            Comment = @"The individual associated with the address has moved and is no longer reachable at the address"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"On request",
                            Comment = @"The associated individual requested that the address be removed from their record"
                        },
                    };
            } 
        }
    }
}
