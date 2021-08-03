using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0266
    {
        public string Id { get { return @"0266"; } }

        public string TableId { get { return @"0266"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Gender Indicator"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"E",
                            Description = @"Either Male Or Female Patients",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Only Female Patients",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Only Male Patients",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
