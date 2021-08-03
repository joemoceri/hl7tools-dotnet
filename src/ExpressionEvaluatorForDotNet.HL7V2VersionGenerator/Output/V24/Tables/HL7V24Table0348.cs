using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0348
    {
        public string Id { get { return @"0348"; } }

        public string TableId { get { return @"0348"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Special program indicator"; } }

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
                            Description = @"EPSDT-CHAP",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"Physically handicapped children’s program",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"03",
                            Description = @"Special federal funding",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"04",
                            Description = @"Family planning",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"05",
                            Description = @"Disability",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"06",
                            Description = @"PPV/Medicare 100% payment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"07",
                            Description = @"Induced abortion-danger to life",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"08",
                            Description = @"Induced abortion victim rape/incest",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
