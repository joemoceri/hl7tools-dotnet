using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0140
    {
        public string Id { get { return @"0140"; } }

        public string TableId { get { return @"0140"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Military Service"; } }

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
                            Value = @"AUSA",
                            Description = @"Australian Army",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AUSAF",
                            Description = @"Australian Air Force",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AUSN",
                            Description = @"Australian Navy",
                            Comment = null
                        },
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
                            Description = @"US Army",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USAF",
                            Description = @"US Air Force",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USCG",
                            Description = @"US Coast Guard",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USMC",
                            Description = @"US Marine Corps",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USN",
                            Description = @"US Navy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USPHS",
                            Description = @"US Public Health Service",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
