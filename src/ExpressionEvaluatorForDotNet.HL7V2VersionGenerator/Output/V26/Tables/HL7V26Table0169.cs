using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0169
    {
        public string Id { get { return @"0169"; } }

        public string TableId { get { return @"0169"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Reporting priority"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"C",
                            Description = @"Call back results",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Rush reporting",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
