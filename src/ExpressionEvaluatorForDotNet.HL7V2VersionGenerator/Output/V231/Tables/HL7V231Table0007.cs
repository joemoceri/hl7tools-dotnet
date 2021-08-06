using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0007
    {
        public string Id { get { return @"0007"; } }

        public string TableId { get { return @"0007"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Admission type"; } }

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
                            Value = @"A",
                            Description = @"Accident",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"Emergency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Labor and Delivery",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Routine",
                            Comment = null
                        },
                    };
            } 
        }
    }
}