using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0110
    {
        public string Id { get { return @"0110"; } }

        public string TableId { get { return @"0110"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Transfer to bad debt code"; } }

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
