using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0356
    {
        public string Id { get { return @"0356"; } }

        public string TableId { get { return @"0356"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Alternate Character Set Handling Scheme"; } }

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
                            Description = @"The character set switching mode specified in HL7 2.5, section 2.7.2 and section 2.A.46, ""XPN - extended person name"".",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO 2022-1994",
                            Description = @"This standard is titled ""Information Technology - Character Code Structure and Extension Technique"". .",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
