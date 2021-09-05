using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0926
    {
        public string Id { get { return @"0926"; } }

        public string TableId { get { return @"0926"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Phlebotomy Status"; } }

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
                            Value = @"NDR",
                            Description = @"Not Drawn",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUC",
                            Description = @"Successful",
                            Comment = @"Successful means a complete component was drawn"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UL5",
                            Description = @"Unsuccessful Less than 50 ml drawn",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
