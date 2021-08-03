using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0935
    {
        public string Id { get { return @"0935"; } }

        public string TableId { get { return @"0935"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Process Interruption Reason"; } }

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
                            Value = @"ASC",
                            Description = @"Apheresis Software Crash",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BSC",
                            Description = @"Manufacturing Software Crash",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CFT",
                            Description = @"Couldn’t follow through with donation (scared)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DBB",
                            Description = @"Bathroom",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DCW",
                            Description = @"Couldn’t wait",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DNI",
                            Description = @"Phlebotomy Issue",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GFE",
                            Description = @"General Facility Emergency",
                            Comment = @"Power outage,  natural disaster (tornado, flood, hurricane, etc.), air conditioning failure, etc."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NRG",
                            Description = @"No reason given, donor decided to stop without giving a reason",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCD",
                            Description = @"Phone Call-Donor",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
