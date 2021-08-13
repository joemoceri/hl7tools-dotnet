using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0570
    {
        public string Id { get { return @"0570"; } }

        public string TableId { get { return @"0570"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Payment Method Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",

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
                            Value = @"CASH",
                            Description = @"Cash",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CCCA",
                            Description = @"Credit Card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CCHK",
                            Description = @"Cashier's Check",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CDAC",
                            Description = @"Credit/Debit Account",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHCK",
                            Description = @"Check",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DDPO",
                            Description = @"Direct Deposit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEBC",
                            Description = @"Debit Card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SWFT",
                            Description = @"Society for Worldwide Interbank Financial Telecommunications (S.W.I.F.T.)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TRAC",
                            Description = @"Traveler's Check",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VISN",
                            Description = @"VISA Special Electronic Funds Transfer Network",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
