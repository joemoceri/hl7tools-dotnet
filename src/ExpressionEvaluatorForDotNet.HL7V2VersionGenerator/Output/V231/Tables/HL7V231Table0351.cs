using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0351
    {
        public string Id { get { return @"0351"; } }

        public string TableId { get { return @"0351"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Occurrence span"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Value = @"70",
                            Description = @"Qualifying stay dates for SNF",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"71",
                            Description = @"Prior stay dates",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"72",
                            Description = @"First/last visit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"73",
                            Description = @"Benefit eligibility period",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"74",
                            Description = @"Non-covered level of care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"75",
                            Description = @"SNF level of care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"76",
                            Description = @"Patient liability",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"77",
                            Description = @"Provider liability period",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"78",
                            Description = @"SNF prior stay dates",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"79",
                            Description = @"Payer code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M0",
                            Description = @"PRO/UR approved stay dates",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
