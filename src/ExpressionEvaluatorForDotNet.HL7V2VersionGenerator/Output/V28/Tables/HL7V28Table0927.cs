using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0927
    {
        public string Id { get { return @"0927"; } }

        public string TableId { get { return @"0927"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Arm Stick"; } }

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
                            Value = @"B",
                            Description = @"Both Arms",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Left Arm",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Right Arm",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
