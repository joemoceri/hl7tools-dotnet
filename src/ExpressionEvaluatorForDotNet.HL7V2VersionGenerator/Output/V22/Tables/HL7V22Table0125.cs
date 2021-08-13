using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0125
    {
        public string Id { get { return @"0125"; } }

        public string TableId { get { return @"0125"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"VALUE TYPE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

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
                            Description = @"Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CE",
                            Description = @"Coded element",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CF",
                            Description = @"Coded element with formatted values",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CK",
                            Description = @"Composite ID with check digit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CM",
                            Description = @"Composite",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CN",
                            Description = @"Composite ID and name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CQ",
                            Description = @"Composite quantity with units",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DT",
                            Description = @"Date",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FT",
                            Description = @"Formatted text (display)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ID",
                            Description = @"Coded value",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MO",
                            Description = @"Money",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NM",
                            Description = @"Numeric",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PN",
                            Description = @"Person name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Reference pointer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SI",
                            Description = @"Sequence ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ST",
                            Description = @"String data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TM",
                            Description = @"Time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TN",
                            Description = @"Telephone number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TQ",
                            Description = @"Timing / quantity",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TS",
                            Description = @"Time stamp ( date & time)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Text data (display)",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
