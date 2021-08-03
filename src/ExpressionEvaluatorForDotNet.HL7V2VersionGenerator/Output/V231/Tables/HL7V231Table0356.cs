using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0356
    {
        public string Id { get { return @"0356"; } }

        public string TableId { get { return @"0356"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Alternate character set handling scheme"; } }

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
                            Value = @"<null>",
                            Description = @"This is the default, indicating that there is no character set switching occurring in this message.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.3",
                            Description = @"The character set switching mode specified in HL7 2.3, sections 2.8.28.6.1, and 2.9.2.  Note that the escape sequences used in this mode do not use the ASCII ""esc"" character. They are ""HL7 escape sequences"" as defined in HL7 2.3, sec.  2.9 as defined in ISO 2022-1994  (Also, note that sections 2.8.28.6.1and 2.9.2 in HL7 2.3 correspond to sections 2.8.31.6.1and 2.9.2  in HL7 2.4.)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO 2022-1994",
                            Description = @"This standard is titled ""Information Technology - Character Code Structure and Extension Technique"". This standard specifies an escape sequence from basic one byte character set to specified other character set, and vice versa.  The escape sequence explicitly specifies what alternate character set to be evoked. Note that in this mode, the actual ASCII escape character is used as defined in the referenced ISO document. As noted in 1.6.1., escape sequences to/from alternate character set should occur within HL7 delimiters. In other words, HL7 delimiters are basic one byte characters only, and just before and just after delimiters, character encoding status should be the basic one byte set.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
