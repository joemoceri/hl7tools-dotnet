using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0383
    {
        public string Id { get { return @"0383"; } }

        public string TableId { get { return @"0383"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Substance Status"; } }

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
                            Value = @"CE",
                            Description = @"Calibration Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CW",
                            Description = @"Calibration Warning",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EE",
                            Description = @"Expired Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EW",
                            Description = @"Expired Warning",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NE",
                            Description = @"Not Available Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NW",
                            Description = @"Not Available Warning",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OE",
                            Description = @"Other Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OK",
                            Description = @"OK Status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OW",
                            Description = @"Other Warning",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QE",
                            Description = @"QC Error",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QW",
                            Description = @"QC Warning",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
