using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0112
    {
        public string Id { get { return @"0112"; } }

        public string TableId { get { return @"0112"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Discharge Disposition"; } }

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
                return null;
            } 
        }
    }
}
