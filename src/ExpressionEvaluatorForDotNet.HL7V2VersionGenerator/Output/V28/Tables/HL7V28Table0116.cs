using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0116
    {
        public string Id { get { return @"0116"; } }

        public string TableId { get { return @"0116"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Bed Status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

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
                            Description = @"Closed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Housekeeping",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Isolated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K",
                            Description = @"Contaminated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Occupied",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unoccupied",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
