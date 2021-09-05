using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0251
    {
        public string Id { get { return @"0251"; } }

        public string TableId { get { return @"0251"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Action taken in response to the event"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

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
                            Value = @"DI",
                            Description = @"Product dose or frequency of use increased",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"Product dose or frequency of use reduced",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"None",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OT",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WP",
                            Description = @"Product withdrawn permanently",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WT",
                            Description = @"Product withdrawn temporarily",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
