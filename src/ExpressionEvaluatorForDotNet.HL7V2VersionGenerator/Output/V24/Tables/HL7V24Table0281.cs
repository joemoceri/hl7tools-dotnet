using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0281
    {
        public string Id { get { return @"0281"; } }

        public string TableId { get { return @"0281"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Referral type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",
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
                            Value = @"Hom",
                            Description = @"Home Care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Lab",
                            Description = @"Laboratory",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Med",
                            Description = @"Medical",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Psy",
                            Description = @"Psychiatric",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Rad",
                            Description = @"Radiology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Skn",
                            Description = @"Skilled Nursing",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
