using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0153
    {
        public string Id { get { return @"0153"; } }

        public string TableId { get { return @"0153"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Value code"; } }

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
