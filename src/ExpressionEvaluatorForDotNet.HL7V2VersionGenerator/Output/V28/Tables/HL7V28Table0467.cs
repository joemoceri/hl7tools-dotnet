using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0467
    {
        public string Id { get { return @"0467"; } }

        public string TableId { get { return @"0467"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Modifier Edit Code"; } }

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
                            Value = @"0",
                            Description = @"Modifier does NOT exist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Modifier present, no errors",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Modifier invalid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Modifier NOT approved for ASC/HOPD use",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Modifier approved for ASC/HOPD use, inappropriate for code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Modifier edit code unknown",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
