using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0004
    {
        public string Id { get { return @"0004"; } }

        public string TableId { get { return @"0004"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Patient class"; } }

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
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"B",
                            Description = @"Obstetrics",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"Emergency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Inpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Outpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Preadmit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Recurring patient",
                            Comment = null
                        },
                    };
            } 
        }
    }
}