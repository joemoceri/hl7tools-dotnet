using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0005
    {
        public string Id { get { return @"0005"; } }

        public string TableId { get { return @"0005"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"ETHNIC GROUP"; } }

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
                            Value = @"B",
                            Description = @"Black",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Caucasian",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Hispanic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Oriental",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
