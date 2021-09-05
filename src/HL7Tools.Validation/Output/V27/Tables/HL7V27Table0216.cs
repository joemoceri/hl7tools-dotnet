using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0216
    {
        public string Id { get { return @"0216"; } }

        public string TableId { get { return @"0216"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Patient Status Code"; } }

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
                            Value = @"AI",
                            Description = @"Active Inpatient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Discharged Inpatient",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
