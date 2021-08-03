using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0130
    {
        public string Id { get { return @"0130"; } }

        public string TableId { get { return @"0130"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Visit User Code"; } }

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
                            Value = @"HO",
                            Description = @"Home",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MO",
                            Description = @"Mobile Unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PH",
                            Description = @"Phone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TE",
                            Description = @"Teaching",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
