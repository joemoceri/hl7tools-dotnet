using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0809
    {
        public string Id { get { return @"0809"; } }

        public string TableId { get { return @"0809"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Maintenance Cycle"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

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
