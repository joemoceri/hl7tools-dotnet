using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0125
    {
        public string Id { get { return @"0125"; } }

        public string TableId { get { return @"0125"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"VALUE TYPE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"CK",
                            Description = @"Composite ID with check digit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FT",
                            Description = @"Formatted Text",
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
                            Value = @"ST",
                            Description = @"String data. Used to transmit numerics.",
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
                            Value = @"TS",
                            Description = @"Time stamp",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Text",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
