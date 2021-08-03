using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0318
    {
        public string Id { get { return @"0318"; } }

        public string TableId { get { return @"0318"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Confirmation Provided By"; } }

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
                return null;
            } 
        }
    }
}
