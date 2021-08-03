using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0838
    {
        public string Id { get { return @"0838"; } }

        public string TableId { get { return @"0838"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Problem Perspective"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",
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
