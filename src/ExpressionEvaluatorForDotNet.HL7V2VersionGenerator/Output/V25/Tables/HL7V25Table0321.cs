using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0321
    {
        public string Id { get { return @"0321"; } }

        public string TableId { get { return @"0321"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Dispense Method"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
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
                            Value = @"AD",
                            Description = @"Automatic Dispensing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Floor Stock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TR",
                            Description = @"Traditional",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UD",
                            Description = @"Unit Dose",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
