using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0001
    {
        public string Id { get { return "0001"; } }

        public string TableId { get { return "0001"; } }

        public string TableType { get { return "User"; } }

        public string Name { get { return "Sex"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                {
                    "CH_03"
                };
            } 
        }

        public IList<HL7V23TableEntry> Entries 
        { 
            get 
            { 
                return new[] 
                { 
                    new HL7V23TableEntry
                    {
                        Value = "F",
                        Description = "Female",
                        Comment = null
                    },
                    new HL7V23TableEntry
                    {
                        Value = "M",
                        Description = "Male",
                        Comment = null
                    },
                    new HL7V23TableEntry
                    {
                        Value = "O",
                        Description = "Other",
                        Comment = null
                    },
                    new HL7V23TableEntry
                    {
                        Value = "U",
                        Description = "Unknown",
                        Comment = null
                    },
                };
            } 
        }
    }
}
