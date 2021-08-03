using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0494
    {
        public string Id { get { return @"0494"; } }

        public string TableId { get { return @"0494"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Specimen Child Role"; } }

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
                            Value = @"A",
                            Description = @"Aliquot",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Component",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Modified from original specimen",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
