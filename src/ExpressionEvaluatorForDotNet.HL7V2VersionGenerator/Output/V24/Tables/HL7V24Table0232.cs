using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0232
    {
        public string Id { get { return @"0232"; } }

        public string TableId { get { return @"0232"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Insurance company contact reason"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Value = @"01",
                            Description = @"Medicare claim status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"Medicaid claim status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"03",
                            Description = @"Name/address change",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
