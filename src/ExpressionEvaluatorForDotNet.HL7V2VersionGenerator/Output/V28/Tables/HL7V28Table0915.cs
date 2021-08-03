using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0915
    {
        public string Id { get { return @"0915"; } }

        public string TableId { get { return @"0915"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Process Control Code"; } }

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
                return null;
            } 
        }
    }
}
