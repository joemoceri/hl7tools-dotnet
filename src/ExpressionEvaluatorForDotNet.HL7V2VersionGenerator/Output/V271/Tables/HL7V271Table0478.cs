using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0478
    {
        public string Id { get { return @"0478"; } }

        public string TableId { get { return @"0478"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Formulary Status"; } }

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
                            Value = @"G",
                            Description = @"Pharmaceutical substance is in the formulary, but guidelines apply",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Pharmaceutical substance is NOT in the formulary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Pharmaceutical substance is in the formulary, but restrictions apply",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"Pharmaceutical substance is in the formulary",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
