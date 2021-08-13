using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0200
    {
        public string Id { get { return @"0200"; } }

        public string TableId { get { return @"0200"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Name type"; } }

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
                            Description = @"Alias Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Adopted Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Display Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Legal Name",
                            Comment = @"The legal name is the same as the current married name"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Maiden Name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Other",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
