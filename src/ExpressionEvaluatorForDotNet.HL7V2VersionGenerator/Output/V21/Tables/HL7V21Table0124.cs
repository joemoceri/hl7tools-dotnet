using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0124
    {
        public string Id { get { return @"0124"; } }

        public string TableId { get { return @"0124"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"TRANSPORTATION MODE"; } }

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
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"PORT",
                            Description = @"The examining device goes to Patient's Loc.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WALK",
                            Description = @"Patient walks to diagnostic service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WHLC",
                            Description = @"Wheelchair",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
