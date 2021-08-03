using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0123
    {
        public string Id { get { return @"0123"; } }

        public string TableId { get { return @"0123"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"RESULT STATUS - OBR"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"C",
                            Description = @"Correction of previously transmitted results",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Final results - results stored & verified",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Specimen in lab, not yet processed.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Preliminary results",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Results stored - not yet verified",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Procedure scheduled, not done",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"No order on record for this test",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Z",
                            Description = @"No record of this patient",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
