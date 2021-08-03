using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0514
    {
        public string Id { get { return @"0514"; } }

        public string TableId { get { return @"0514"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Transfusion Adverse Reaction"; } }

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
                            Value = @"ABOINC",
                            Description = @"ABO Incompatible Transfusion Reaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACUTHEHTR",
                            Description = @"Acute Hemolytic Transfusion Reaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALLERGIC1",
                            Description = @"Allergic Reaction - First",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALLERGIC2",
                            Description = @"Allergic Reaction - Recurrent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALLERGICR",
                            Description = @"Allergic Reaction - Repeating",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANAPHYLAC",
                            Description = @"Anaphylactic Reaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BACTCONTAM",
                            Description = @"Reaction to Bacterial Contamination",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DELAYEDHTR",
                            Description = @"Delayed Hemolytic Transfusion Reaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DELAYEDSTR",
                            Description = @"Delayed Serological Transfusion Reaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GVHD",
                            Description = @"Graft vs Host Disease - Transfusion - Associated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HYPOTENS",
                            Description = @"Non-hemolytic Hypotensive Reaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NONHTR1",
                            Description = @"Non-Hemolytic Fever Chill Transfusion Reaction - First",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NONHTR2",
                            Description = @"Non-Hemolytic Fever Chill Transfusion Reaction - Recurrent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NONHTRREC",
                            Description = @"Non-Hemolytic Fever Chill Transfusion Reaction - Repeating",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NONIMMUNE",
                            Description = @"Non-Immune Hemolysis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NONSPEC",
                            Description = @"Non-Specific, Non-Hemolytic Transfusion Reaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NORXN",
                            Description = @"No Evidence of Transfusion Reaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PTP",
                            Description = @"Posttransfusion Purpura",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VOLOVER",
                            Description = @"Symptoms most likely due to volume overload",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
