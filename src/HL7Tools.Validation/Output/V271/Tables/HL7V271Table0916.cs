using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0916
    {
        public string Id { get { return @"0916"; } }

        public string TableId { get { return @"0916"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Relevant Clinical Information"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Value = @"F",
                            Description = @"Patient was fasting prior to the procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FNA",
                            Description = @"Fasting not asked of the patient at time of procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NF",
                            Description = @"The patient indicated they did not fast prior to the procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NG",
                            Description = @"Not Given – Patient was not asked at the time of the procedure",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
