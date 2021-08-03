using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0181
    {
        public string Id { get { return @"0181"; } }

        public string TableId { get { return @"0181"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"MFN RECORD-LEVEL ERROR RETURN"; } }

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
                            Value = @"S",
                            Description = @"Successful posting of the record defined by the MFE segment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unsuccessful posting of the record defined by the MFE segment",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
