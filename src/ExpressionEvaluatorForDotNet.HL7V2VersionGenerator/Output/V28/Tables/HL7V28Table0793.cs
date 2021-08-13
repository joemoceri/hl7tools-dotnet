using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0793
    {
        public string Id { get { return @"0793"; } }

        public string TableId { get { return @"0793"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Ruling Act"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

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
                            Value = @"SMDA",
                            Description = @"Safe Medical Devices Act",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
