using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0021
    {
        public string Id { get { return @"0021"; } }

        public string TableId { get { return @"0021"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Bad Debt Agency Code"; } }

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
