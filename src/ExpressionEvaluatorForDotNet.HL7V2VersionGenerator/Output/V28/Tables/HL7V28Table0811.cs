using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0811
    {
        public string Id { get { return @"0811"; } }

        public string TableId { get { return @"0811"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Maintenance Type"; } }

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
