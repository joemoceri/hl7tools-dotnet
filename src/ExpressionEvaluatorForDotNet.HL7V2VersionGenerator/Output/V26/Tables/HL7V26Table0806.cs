using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0806
    {
        public string Id { get { return @"0806"; } }

        public string TableId { get { return @"0806"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Sterilization Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",
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
                            Value = @"EOG",
                            Description = @"Ethylene Oxide Gas",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCA",
                            Description = @"Peracetic acid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STM",
                            Description = @"Steam",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
