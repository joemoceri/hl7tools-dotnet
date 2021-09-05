using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0175
    {
        public string Id { get { return @"0175"; } }

        public string TableId { get { return @"0175"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Master file identifier code"; } }

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
                            Value = @"CDM",
                            Description = @"Charge description master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CM0",
                            Description = @"Clinical study master",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CM1",
                            Description = @"Clinical study phase master",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CM2",
                            Description = @"Clinical study Data Schedule Master",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LOC",
                            Description = @"Location master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM1",
                            Description = @"Observation test master file segments",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM2",
                            Description = @"Observation test master file segments",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM3",
                            Description = @"Observation test master file segments",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM4",
                            Description = @"Observation test master file segments",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM5",
                            Description = @"Observation test master file segments",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OM6",
                            Description = @"Observation test master file segments",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRA",
                            Description = @"Practitioner master file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STF",
                            Description = @"Staff master file",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
