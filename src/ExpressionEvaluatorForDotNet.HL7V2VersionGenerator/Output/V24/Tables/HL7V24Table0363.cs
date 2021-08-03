using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0363
    {
        public string Id { get { return @"0363"; } }

        public string TableId { get { return @"0363"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Assigning authority"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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
                            Value = @"AUSDVA",
                            Description = @"Australia - Dept. of Veterans Affairs",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AUSHIC",
                            Description = @"Australia - Health Insurance Commission",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANAB",
                            Description = @"Canada - Alberta",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANBC",
                            Description = @"Canada - British Columbia",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANMB",
                            Description = @"Canada - Manitoba",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANNB",
                            Description = @"Canada - New Brunswick",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANNF",
                            Description = @"Canada - Newfoundland",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANNS",
                            Description = @"Canada - Nova Scotia",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANNT",
                            Description = @"Canada - Northwest Territories",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANNU",
                            Description = @"Canada - Nanavut",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANON",
                            Description = @"Canada - Ontario",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANPE",
                            Description = @"Canada - Prince Edward Island",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANQC",
                            Description = @"Canada - Quebec",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANSK",
                            Description = @"Canada - Saskatchewan",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANYT",
                            Description = @"Canada - Yukon Territories",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NLVWS",
                            Description = @"NL - Ministerie van Volksgezondheid, Welzijn en Sport",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USCDC",
                            Description = @"US Center for Disease Control",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USHCFA",
                            Description = @"US Healthcare Finance Authority",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USSSA",
                            Description = @"US Social Security Administration",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
