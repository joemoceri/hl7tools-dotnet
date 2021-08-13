using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0465
    {
        public string Id { get { return @"0465"; } }

        public string TableId { get { return @"0465"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Name/address representation"; } }

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
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"A",
                            Description = @"Alphabetic (i.e., Default or some single-byte)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Ideographic (i.e., Kanji)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Phonetic (i.e., ASCII, Katakana, Hiragana, etc.)",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
