using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0432
    {
        public string Id { get { return @"0432"; } }

        public string TableId { get { return @"0432"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Admission Level of Care Code"; } }

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
                            Value = @"AC",
                            Description = @"Acute",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CH",
                            Description = @"Chronic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CO",
                            Description = @"Comatose",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CR",
                            Description = @"Critical",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IM",
                            Description = @"Improved",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MO",
                            Description = @"Moribund",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
