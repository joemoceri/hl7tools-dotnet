using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table9999
    {
        public string Id { get { return @"9999"; } }

        public string TableId { get { return @"9999"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"no table for CE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
