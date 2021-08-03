using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0122
    {
        public string Id { get { return @"0122"; } }

        public string TableId { get { return @"0122"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Charge Type"; } }

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
                            Value = @"CH",
                            Description = @"Charge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CO",
                            Description = @"Contract",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CR",
                            Description = @"Credit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DP",
                            Description = @"Department",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GR",
                            Description = @"Grant",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NC",
                            Description = @"No Charge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC",
                            Description = @"Professional",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RS",
                            Description = @"Research",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
