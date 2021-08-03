using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0717
    {
        public string Id { get { return @"0717"; } }

        public string TableId { get { return @"0717"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Access Restriction Value"; } }

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
                            Value = @"ALL",
                            Description = @"All",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEM",
                            Description = @"All demographic data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DRG",
                            Description = @"Drug",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HIV",
                            Description = @"HIV status and results",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LOC",
                            Description = @"Patient Location",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NO",
                            Description = @"None",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OI",
                            Description = @"Opt in all registries (HIPAA)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OO",
                            Description = @"Opt out all registries (HIPAA)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PID-17",
                            Description = @"Religion",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PID-7",
                            Description = @"Date of Birth",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PSY",
                            Description = @"Psychiatric Mental health",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SMD",
                            Description = @"Sensitive medical data",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STD",
                            Description = @"Sexually transmitted diseases",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
