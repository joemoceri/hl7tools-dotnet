using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0140
    {
        public string Id { get { return @"0140"; } }

        public string TableId { get { return @"0140"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Military service"; } }

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
                            Value = @"NATO",
                            Description = @"North Atlantic Treaty Organization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NOAA",
                            Description = @"National Oceanic and Atmospheric Administration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USA",
                            Description = @"U.S. Army",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USAF",
                            Description = @"U.S. Air Force",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USCG",
                            Description = @"U.S. Coast Guard",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USMC",
                            Description = @"U.S. Marines",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USN",
                            Description = @"U.S. Navy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USPHS",
                            Description = @"U.S. Public Health Service",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
