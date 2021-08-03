using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0279
    {
        public string Id { get { return @"0279"; } }

        public string TableId { get { return @"0279"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Allow Substitution Codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",
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
                            Value = @"Confirm",
                            Description = @"Contact the Placer Contact Person prior to making any substitutions of this resource",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"No",
                            Description = @"Substitution of this resource is not allowed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Notify",
                            Description = @"Notify the Placer Contact Person, through normal institutional procedures, that a substitution of this resource has been made",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Yes",
                            Description = @"Substitution of this resource is allowed",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
