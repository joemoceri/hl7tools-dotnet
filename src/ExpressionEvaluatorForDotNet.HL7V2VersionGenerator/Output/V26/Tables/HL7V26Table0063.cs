using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0063
    {
        public string Id { get { return @"0063"; } }

        public string TableId { get { return @"0063"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Relationship"; } }

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
                            Value = @"ASC",
                            Description = @"Associate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BRO",
                            Description = @"Brother",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CGV",
                            Description = @"Care giver",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHD",
                            Description = @"Child",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEP",
                            Description = @"Handicapped dependent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DOM",
                            Description = @"Life partner",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EMC",
                            Description = @"Emergency contact",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EME",
                            Description = @"Employee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EMR",
                            Description = @"Employer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXF",
                            Description = @"Extended family",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FCH",
                            Description = @"Foster child",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FND",
                            Description = @"Friend",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FTH",
                            Description = @"Father",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GCH",
                            Description = @"Grandchild",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GRD",
                            Description = @"Guardian",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GRP",
                            Description = @"Grandparent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MGR",
                            Description = @"Manager",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MTH",
                            Description = @"Mother",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NCH",
                            Description = @"Natural child",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NON",
                            Description = @"None",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OAD",
                            Description = @"Other adult",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OTH",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OWN",
                            Description = @"Owner",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAR",
                            Description = @"Parent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCH",
                            Description = @"Stepchild",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SEL",
                            Description = @"Self",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SIB",
                            Description = @"Sibling",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SIS",
                            Description = @"Sister",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPO",
                            Description = @"Spouse",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TRA",
                            Description = @"Trainer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNK",
                            Description = @"Unknown",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WRD",
                            Description = @"Ward of court",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
