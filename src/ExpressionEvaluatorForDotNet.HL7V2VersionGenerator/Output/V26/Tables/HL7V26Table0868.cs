using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0868
    {
        public string Id { get { return @"0868"; } }

        public string TableId { get { return @"0868"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Telecommunication expiration reason"; } }

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
                            Comment = @"The telecommunication address has been replaced with a corrected version"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"Added in error",
                            Comment = @"The telecommunication address was incorrect and should never have been associated with the individual"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Moved",
                            Comment = @"The individual associated with the telecommunication address has moved and is no longer reachable at the address"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"No longer in service",
                            Comment = @"The telecommunication address is no longer connected or available"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"On request",
                            Comment = @"The associated individual requested that the telecommunication address be removed from their record (though it may still be correct)."
                        },
                    };
            } 
        }
    }
}
