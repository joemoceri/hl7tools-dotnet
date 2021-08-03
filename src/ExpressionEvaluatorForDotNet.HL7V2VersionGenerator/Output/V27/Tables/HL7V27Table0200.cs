using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0200
    {
        public string Id { get { return @"0200"; } }

        public string TableId { get { return @"0200"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Name Type"; } }

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
                            Description = @"Assigned",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B",
                            Description = @"Birth name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAD",
                            Description = @"Bad Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Adopted Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Customary Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Licensing Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K",
                            Description = @"Business name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Official Registry Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Maiden Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MSK",
                            Description = @"Masked",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Nickname",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAV",
                            Description = @"Temporarily Unavailable",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NB",
                            Description = @"Newborn Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NOUSE",
                            Description = @"No Longer To Be Used",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Name of Partner/Spouse",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Registered Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REL",
                            Description = @"Religious",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Pseudonym",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Indigenous/Tribal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TEMP",
                            Description = @"Temporary Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unknown",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
