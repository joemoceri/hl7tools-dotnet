using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0344
    {
        public string Id { get { return @"0344"; } }

        public string TableId { get { return @"0344"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Patient's Relationship to Insured"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Value = @"01",
                            Description = @"Patient is insured",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"Spouse",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"03",
                            Description = @"Natural child/insured financial responsibility",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"04",
                            Description = @"Natural child/Insured does not have financial responsibility",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"05",
                            Description = @"Step child",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"06",
                            Description = @"Foster child",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"07",
                            Description = @"Ward of the court",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"08",
                            Description = @"Employee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"09",
                            Description = @"Unknown",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"10",
                            Description = @"Handicapped dependent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"11",
                            Description = @"Organ donor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"12",
                            Description = @"Cadaver donor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"13",
                            Description = @"Grandchild",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"14",
                            Description = @"Niece/nephew",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"15",
                            Description = @"Injured plaintiff",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"16",
                            Description = @"Sponsored dependent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"17",
                            Description = @"Minor dependent of a minor dependent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"18",
                            Description = @"Parent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"19",
                            Description = @"Grandparent",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
