using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0924
    {
        public string Id { get { return @"0924"; } }

        public string TableId { get { return @"0924"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Cumulative Dosage Limit UoM"; } }

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
                            Value = @"A",
                            Description = @"Annual",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Per Day",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Per Month",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Duration of the Order",
                            Comment = @"Not from UCUM"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PL",
                            Description = @"Patients Lifetime",
                            Comment = @"Not fromUCUM"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WK",
                            Description = @"Per Week",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
