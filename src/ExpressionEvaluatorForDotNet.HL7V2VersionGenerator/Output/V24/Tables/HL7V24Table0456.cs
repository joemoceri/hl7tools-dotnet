using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0456
    {
        public string Id { get { return @"0456"; } }

        public string TableId { get { return @"0456"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Revenue code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Value = @"260",
                            Description = @"IV Therapy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"280",
                            Description = @"Oncology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"301",
                            Description = @"Lab/Chemistry",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"991",
                            Description = @"Cafeteria /Guest Tray",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"993",
                            Description = @"Telephone/Telegraph",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"994",
                            Description = @"TV/Radio",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
