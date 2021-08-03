using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0443
    {
        public string Id { get { return @"0443"; } }

        public string TableId { get { return @"0443"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Provider role"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",
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
                            Description = @"Admitting",
                            Comment = @"PV1-17 Admitting doctor"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AT",
                            Description = @"Attending",
                            Comment = @"PV1-7 Attending doctor"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Consulting Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FHCP",
                            Description = @"Family Health Care Professional",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PP",
                            Description = @"Primary Care Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Referring Provider",
                            Comment = @"PV1-8 Referring doctor"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RT",
                            Description = @"Referred to Provider",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
