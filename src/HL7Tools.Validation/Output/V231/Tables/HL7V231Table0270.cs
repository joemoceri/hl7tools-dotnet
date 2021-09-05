using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0270
    {
        public string Id { get { return @"0270"; } }

        public string TableId { get { return @"0270"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Document type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

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
                            Value = @"AR",
                            Description = @"Autopsy report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CD",
                            Description = @"Cardiodiagnostics",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CN",
                            Description = @"Consultation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Diagnostic imaging",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DS",
                            Description = @"Discharge summary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ED",
                            Description = @"Emergency department report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HP",
                            Description = @"History and physical examination",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OP",
                            Description = @"Operative report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC",
                            Description = @"Psychiatric consultation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PH",
                            Description = @"Psychiatric history and physical examination",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PN",
                            Description = @"Procedure note",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PR",
                            Description = @"Progress note",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SP",
                            Description = @"Surgical pathology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TS",
                            Description = @"Transfer summary",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
