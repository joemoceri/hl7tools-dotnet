using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0369
    {
        public string Id { get { return @"0369"; } }

        public string TableId { get { return @"0369"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Specimen role"; } }

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
                            Value = @"B",
                            Description = @"Blind Sample",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Calibrator",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Patient (default if blank component value)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q",
                            Description = @"Control specimen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Replicate (of patient sample as a control)",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
