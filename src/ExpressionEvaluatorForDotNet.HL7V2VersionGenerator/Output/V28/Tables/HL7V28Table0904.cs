using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0904
    {
        public string Id { get { return @"0904"; } }

        public string TableId { get { return @"0904"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Security Check Scheme"; } }

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
                            Value = @"BCV",
                            Description = @"Bank Card Validation Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CCS",
                            Description = @"Credit Card Security code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VID",
                            Description = @"Version ID",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
